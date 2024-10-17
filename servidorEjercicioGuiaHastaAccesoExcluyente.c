#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <ctype.h>
#include <pthread.h>

int contador;

//Estructura necesaria para acceso excluyente
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

void *AtenderCliente (void *socket)
{
	int sock_conn;
	int *s;
	s = (int *) socket;
	sock_conn = *s;
	
	
	//int socket_conn = * (int *) socket;
	char peticion[512];
	char respuesta[512];
	int ret;
	
	int terminar = 0;
	//entramos en bucle para atender todas las peticiones de este cliente hasta q se desconecte
	while (terminar == 0)
	{
		//Ahora recibimos la peticin
		ret = read(sock_conn, peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		//Tenemos que añadirle la marca de fin de string para que no escriba lo que hay despues del buffer
		peticion[ret]='\0';
		
		printf("Peticion: %s\n", peticion);
		
		//vamos a ver que quiern
		char *p = strtok(peticion, "/");
		int codigo = atoi (p);
		//Ya tenemos el codigo de la peticion
		char nombre [20];
		int es_palindromo = 1;
		
		if ((codigo) != 0 && (codigo != 4))
		{
			p = strtok(NULL, "/");
			strcpy(nombre, p);
			//Ya tenemos el nombre
			printf("Codigo: %d, Nombre: %s\n", codigo, nombre);
		}
		if (codigo == 0)
			terminar=1; //cliente quiere terminar la conexion
		else if (codigo == 1) //piden la longitd del nombre
			sprintf (respuesta,"%d",strlen (nombre));
		else if(codigo == 2)
		{
			// quieren saber si el nombre es bonito
			if((nombre[0]=='M') || (nombre[0]=='S'))
				strcpy (respuesta,"SI");
			else
				strcpy (respuesta,"NO");
		}
		else if (codigo == 3) //decir si es alto
		{
			p = strtok(NULL, "/");
			float altura =  atof (p);
			if (altura > 1.70)
				sprintf (respuesta, "%s: eres alto", nombre);
			else
				sprintf (respuesta, "%s: eres bajo", nombre);
		}
		else if (codigo == 6) //decir si es palindromo
		{
			for (int i = 0; i < strlen(nombre) / 2; i++) 
			{
				if (tolower(nombre[i]) != tolower(nombre[strlen(nombre)-i-1])) 
				{
					es_palindromo = 0;
					break;
				}
			}
			if (es_palindromo)
				strcpy(respuesta, "SI");
			else
				strcpy(respuesta, "NO");
		}
		else if (codigo == 5)
		{
			for (int i = 0; nombre[i]; i++) {
				nombre[i] = toupper(nombre[i]);
			}
			sprintf(respuesta, "Tu nombre en mayusculas es: %s", nombre);
		}
		else if (codigo = 4)
			sprintf (respuesta,"%d",contador);
		
		if (codigo !=0)
		{
			// Enviamos la respuesta al cliente
			printf("Respuesta: %s\n", respuesta);
			write(sock_conn, respuesta, strlen(respuesta));
		}
		if ((codigo == 1) || (codigo == 2) || (codigo == 3) || (codigo == 5) || (codigo == 6))
			pthread_mutex_lock (&mutex); //no me interrumpas ahora
			contador = contador + 1;
			pthread_mutex_unlock (&mutex); //ya puedes interrumpirme
	}
	// Cerramos la conexion con este cliente
	close(sock_conn);
	}
	

int main(int argc, char *argv[])
{
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9150);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 4) < 0)
		printf("Error en el Listen");
	
	contador = 0;
	int sockets [100];
	int i;
	i=0;
	pthread_t thread;
	// Bucle infinito
	for(;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		
		sockets[i] = sock_conn;
		//sock_conn es el socket que usaremos para este cliente
		
		//Crear thread y decirle lo que tiene q hacer
		pthread_create(&thread, NULL, AtenderCliente, &sockets[i]);
		i=i+1;
	}
	
}

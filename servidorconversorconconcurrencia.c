#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <ctype.h>
#include <pthread.h>

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
	float temperatura = 0;
	
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
		int codigo =  atoi (p);
		
		if (codigo !=0)
		{
			p = strtok( NULL, "/");
			temperatura = atof(p);
			printf("Codigo: %d, Temperatura: %.2f\n", codigo, temperatura);
		}
		if (codigo == 0)
			terminar = 1;
		else if (codigo == 1) //convertir de celsius a farenheit
		{
			float fahrenheit = (temperatura * 9/5) + 32;
			sprintf(respuesta, "%.2f", fahrenheit);
		}
		else if (codigo == 2) //convertir de farenheit a celsius
		{
			float celsius = (temperatura - 32) * 5/9;
			sprintf(respuesta, "%.2f", celsius);
		}
		
		if (codigo !=0)
		{
			// Enviamos la respuesta al cliente
			printf("Respuesta: %s\n", respuesta);
			write(sock_conn, respuesta, strlen(respuesta));
		}
	}
	// Se acabo el servicio para este cliente
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
	serv_adr.sin_port = htons(9020);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 4) < 0)
		printf("Error en el Listen");
	
	int sockets [100];
	int i;
	i=0;
	pthread_t thread;
	// Bucle infinito
	for(;;)
	{
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

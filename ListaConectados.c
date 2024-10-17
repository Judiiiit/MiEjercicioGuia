#include <stdio.h>
#include <string.h>

//Definicion estructura
typedef struct{
	char nombre [20];
	int socket;
}Conectado;
	
typedef struct{
	Conectado conectados [100];
	int num;
}ListaConectados;

//Añadir un nuevo conectado
int Pon (ListaConectados *lista, char nombre[20], int socket)
{
	//Retorna 0 si ok y -1 si la lista ya estaba llena y no lo ha podido añadir
	if(lista->num == 100)
		return -1;
	else{
		strcpy(lista->conectados[lista->num].nombre, nombre);
		lista->conectados[lista->num].socket = socket;
		lista->num++;
		return 0;
	}
}

int DamePosicion(ListaConectados *lista, char nombre[20])
{
	//Devuelve la posicion en la lista o -1 si no está en la lista
	int i = 0;
	int encontrado = 0;
	while ((i < lista->num) && !encontrado)
	{
		if (strcmp(lista->conectados[i].nombre, nombre) == 0)
			encontrado = 1;
		if (!encontrado)
			i = i + 1;
	}
	if (encontrado)
		return i;
	else
		return -1;
}

int Elimina(ListaConectados *lista, char nombre[20])
{
	//Retorna 0 si elimina y -1 si ese usuario no esta en la lista
	int pos = DamePosicion(lista, nombre);
	if (pos == -1)
		return -1;
	else
	{
		int i;
		for (i = pos; i<lista->num-1; i++)
		{
			lista->conectados[i] = lista->conectados[i+1];
			//strcpy(lista->conectados[i].nombre = lista->conectados[i+1].nombre);
			//lista->conectados[i].socket = lista->conectados[i+1].socket;
		}
		lista->num--;
		return 0;
	}
}

void DameConectados (ListaConectados *lista, char conectados[300])
{
	//Pone en conectados los nombres de todos los conectados separados por /. 
	//Primero pone el numero de conectados. Ejemplo: "3/Juan/Maria/Pedro"
	sprintf(conectados, "%d", lista->num);
	int i;
	for (i=0; i<lista->num; i++)
		sprintf(conectados, "%s/%s", conectados, lista->conectados[i].nombre);
}


int main(int argc, char *argv[]) {
	ListaConectados miLista;
	miLista.num = 0;
	
	Pon(&miLista, "Pedro", 3);
	Pon(&miLista, "Maria", 14);
	Pon(&miLista, "Carlos", 30);
	Pon(&miLista, "Julian", 32);
	int res = Pon(&miLista, "Juan", 5);
	if (res == -1)
		printf("Lista llena. No se puede añadir.\n");
	else
		printf("Añadido bien.\n");
	
	int pos = DamePosicion(&miLista, "Juan");
	if (pos != -1)
		printf("El socket de Juan es: %d\n", miLista.conectados[pos].socket);
	else
		printf("Ese usuario no esta en la lista.\n");
	
	res = Elimina (&miLista, "Juan");
	if (res == -1)
		printf ("No está.\n");
	else
		printf("Eliminado.\n");
	
	pos = DamePosicion(&miLista, "Juan");
	if (pos != -1)
		printf("El socket de Juan es: %d\n", miLista.conectados[pos].socket);
	else
		printf("Ese usuario no esta en la lista.\n");
	
	char misConectados[300];
	DameConectados (&miLista, misConectados);
	printf("Resultado: %s\n", misConectados);
	
	char *p = strtok(misConectados, "/");
	int n = atoi(p);
	int i;
	for (i=0; i<n; i++)
	{
		char nombre [20];
		p = strtok (NULL, "/");
		strcpy (nombre, p);
		printf("Conectado: %s\n", nombre);
	}
	
	return 0;
}


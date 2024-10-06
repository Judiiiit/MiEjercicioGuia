#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	//Dividir
	char peticion[100];
	strcpy(peticion, "3/Judit/20/1.65");
	
	int codigo;
	char nombre[20];
	int edad;
	float altura;
	
	char *p = strtok (peticion, "/");
	codigo = atoi(p);
	p = strtok (NULL, "/");
	strcpy (nombre, p);
	p = strtok (NULL, "/");
	edad = atoi(p);
	p = strtok (NULL, "/");
	altura = atof(p);
	
	printf("Codigo: %d, nombre: %s, edad: %d, altura: %f\n", codigo, nombre, edad, altura);
	
	
	//Crear respuesta
	char respuesta[100];
	if (edad>18)
		sprintf(respuesta, "%s es mayor de edad porque tiene %d años", nombre, edad);
	else
		sprintf(respuesta, "%s no es mayor de edad", nombre);
	
	printf("Respuesta: %s\n", respuesta);
	
}


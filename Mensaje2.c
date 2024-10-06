#include <stdio.h>
#include <string.h>
#include <stdlib.h>


int main(int argc, char *argv[]) {
	
	char peticion[100];
	char respuesta[100];
	
	strcpy(peticion, "Judit/20/Mario/10/Maria/21/Biel/17");  //el resultado ha de incluir solo a los mayores de edad: "Judit*20-Maria*21"
	
	char nombre[20];
	int edad;
	char *p = strtok(peticion, "/");
	while (p!=NULL)
	{
		strcpy(nombre,p);
		p = strtok (NULL, "/");
		edad = atoi(p);
		if (edad > 18)
			sprintf (respuesta, "%s%s*%d-", respuesta, nombre, edad);
		p = strtok (NULL, "/");
	}
	respuesta [strlen (respuesta) -1] = '\0';
	printf ("Resultado: %s\n", respuesta);
	
}


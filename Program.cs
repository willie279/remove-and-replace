// See https://aka.ms/new-console-template for more information
//Remove(int32,int32)
string data = "12345Jhon Smith        5000   3  ";
string newData = data.Remove(5,20);
Console.WriteLine(newData);

//Replace(char,char)
//Aquí se ha usado dos veces el método Replace(). 
//La primera vez, se ha reemplazado la cadena --- por un espacio.
// La segunda, se ha reemplazado la cadena - por una cadena vacía,
// lo que elimina completamente el carácter de la cadena.
string message ;
message = "This --- is --- ex-amp-le---da-ta";
message = message.Replace("---", " ");
message = message.Replace("-", "");
Console.WriteLine(message);



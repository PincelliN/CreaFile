
string path = "MyFile.txt";

var newFile = File.CreateText(path);
//scrivo nel documento creato
newFile.WriteLine("Lorem");
//chiudo la connesione con newFile
newFile.Close();
//elimino la variabile newFile per risparmiare risorse
newFile.Dispose();


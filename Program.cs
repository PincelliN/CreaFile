
string path = "MyFile.txt";

var newFile = File.CreateText(path);
newFile.WriteLine("Lorem");
newFile.Close();
newFile.Dispose();
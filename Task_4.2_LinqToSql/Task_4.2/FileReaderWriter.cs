using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Task_4._2.Salad.Products;

namespace Task_4._2
{
    public static class FileReaderWriter
    {
        public static void WriteAndRead()
        {
            WriteToTxt();
            ReadFromTxt();
            WriteToFile(delegateBinForWriting, "File.bin");
            ReadFromFile(delegateBinForReading, "File.bin");
            WriteToFile(delegateXmlForWriting, "File.xml");
            ReadFromFile(delegateXmlForReading, "File.xml");
        }
        //Creating a txt file and writing the content of the console into it
        static void WriteToTxt()
        {
            FileStream fileStream;
            StreamWriter streamWriter;
            TextWriter oldOut = Console.Out;
            try
            {
                fileStream = new FileStream("File.txt", FileMode.OpenOrCreate, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
            }
            catch (IOException e)
            {
                Console.WriteLine("Cannot open File.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(streamWriter);
            SaladToMake application = new SaladToMake();
            application.StartApplication();
            streamWriter.Close();
            Console.SetOut(oldOut);
            fileStream.Close();
            Console.WriteLine("The content of Console is written into File.txt");
            Console.WriteLine();
        }

        static void ReadFromTxt()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader streamReader = new StreamReader("File.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line = streamReader.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        // delegates are used to avoid repetion of the code for writing\reading to .bin and .xml files
        delegate void NewDelegate(FileStream filestream, SaladToMake application);

        //delegateBinForWriting is called when writing to .bin file
        static NewDelegate delegateBinForWriting = (FileStream filestream, SaladToMake application) =>
        {
            var formatter = new BinaryFormatter();
            formatter.Serialize(filestream, application);
        };

        //delegateXmlForWriting is called when writing to .xml file
        static NewDelegate delegateXmlForWriting = (FileStream filestream, SaladToMake application) =>
        {
            var serializer = new XmlSerializer(typeof(SaladToMake));
            serializer.Serialize(filestream, application);
        };

        // writing to .bin or .xml file using delegates
        static void WriteToFile(NewDelegate delegateBinOrXml, string fileName)
        {
            var application = new SaladToMake();
            FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            try
            {
                delegateBinOrXml(fileStream, application);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fileStream.Close();
            }
        }

        //delegateBinForWriting is called when reading from .bin file
        static NewDelegate delegateBinForReading = (FileStream fileStream, SaladToMake application) =>
        {
            var formatter = new BinaryFormatter();
            application = (SaladToMake)formatter.Deserialize(fileStream);
        };

        //delegateXmlForWriting is called when reading from .xml file
        static NewDelegate delegateXmlForReading = (FileStream fileStream, SaladToMake application) =>
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SaladToMake));
            application = (SaladToMake)serializer.Deserialize(fileStream);
        };

        //Deserializing the object of class SaladToMake
        static void ReadFromFile(NewDelegate delegateBinOrXml, string fileName)
        {
            var application = new SaladToMake();
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            try
            {
                delegateBinOrXml(fileStream, application);
                application.StartApplication();
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}

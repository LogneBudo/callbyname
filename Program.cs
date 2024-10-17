using System;
using System.IO;
using java.io;
using opennlp.tools.namefind;
using Console = System.Console;

namespace CallByName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Paths to the model files for person and organization named entity recognition
            var personModelFilePath = "en-ner-person.bin";
            var organizationModelFilePath = "en-ner-organization.bin";

            // Load the models using FileInputStream
            var personModelStream = new FileInputStream(personModelFilePath);
            var organizationModelStream = new FileInputStream(organizationModelFilePath);

            // Initialize the NameFinderME instances with the respective models
            var personNameFinder = new NameFinderME(new TokenNameFinderModel(personModelStream));
            var organizationNameFinder = new NameFinderME(new TokenNameFinderModel(organizationModelStream));

            // Sample text to be analyzed
            string text = "John Smith is a software engineer at Microsoft";
            var tokens = text.Split(' ');

            // Find named entities in the text using both models
            var personNameSpans = personNameFinder.find(tokens);
            var organizationNameSpans = organizationNameFinder.find(tokens);

            // Output the named entities found
            Console.WriteLine("Named entities found:");

            // Print the person named entities
            foreach (var span in personNameSpans)
            {
                Console.WriteLine($"Person: {string.Join(" ", tokens, span.getStart(), span.length())}");
            }

            // Print the organization named entities
            foreach (var span in organizationNameSpans)
            {
                Console.WriteLine($"Organization: {string.join(" ", tokens, span.getStart(), span.length())}");
            }
        }
    }
}

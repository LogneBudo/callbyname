# CallByName

CallByName is a .NET Framework 4.8 application that demonstrates the use of the OpenNLP library for named entity recognition (NER). This application identifies named entities such as persons and organizations in a given text.

## Features

- Recognizes person names using the `en-ner-person.bin` model.
- Recognizes organization names using the `en-ner-organization.bin` model.
- Outputs the identified named entities to the console.

## Prerequisites

- .NET Framework 4.8
- IKVM.NET library for Java interoperability
- OpenNLP models (`en-ner-person.bin` and `en-ner-organization.bin`)

## Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/yourusername/CallByName.git
   cd CallByName
```

2. **Add OpenNLP.NET library:**

    Install the OpenNLP.NET library via NuGet Package Manager in Visual Studio:

```bash
    Install-Package OpenNLP.NET
```

3. **Download OpenNLP models:**

    Download the `en-ner-person.bin` and `en-ner-organization.bin` models from the [OpenNLP website](https://opennlp.apache.org/models.html) and place them in the project directory.

## Usage

1. **Build the project:**

    Open the project in Visual Studio and build it.

2. **Run the application:**

    Run the application from Visual Studio. The console will display the named entities found in the sample text.

## Code Explanation

The main logic of the application is in the `Program.cs` file. Below is a detailed explanation of the code:

### Explanation of Key Components

- **Model Paths**: Specifies the paths to the NER models for persons and organizations.
- **FileInputStream**: Loads the models using `FileInputStream`.
- **NameFinderME Initialization**: Initializes `NameFinderME` instances with the respective models.
- **Sample Text**: The text to be analyzed for named entities.
- **Finding Named Entities**: Uses the models to find named entities in the text.
- **Output**: Prints the named entities found to the console.

## Illustration

Below is an example of the console output when the application is run:

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License.
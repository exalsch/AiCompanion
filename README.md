# AiCompanion

AiCompanion is a Windows-exclusive .NET 4.8 application designed to enhance day-to-day workflows by providing seamless interaction with OpenAI's API. Whether you're looking to send prompts, use Text-to-Speech, or convert speech to text, AiCompanion makes it easy and efficient.

> **Note:** This application is in the early stages of development but is already fully usable.

## Features

AiCompanion offers three primary functions:

### 1. **Prompt**
Effortlessly send any selected text as a prompt to OpenAI. The application also supports custom pre-prompts, allowing you to enforce a specific behavior or style for the generated response. This is especially useful for enforcing tone, role-playing, or specific formats in the replies.

### 2. **Text-To-Speech (TTS)**
Convert selected text into speech by sending it to a Text-To-Speech (TTS) endpoint. You can listen to the AI-generated voice read out the text or download the audio file for later use.

### 3. **Speech-To-Text (STT)**
Transcribe your voice recordings into text using AiCompanion's Speech-To-Text feature. This enables easy conversion of audio input into text, which can then be used across other applications.

## Workflow Integration

One of AiCompanion's key benefits is its ability to smoothly integrate into your existing workflow. After activating the tool with the main hotkey, AiCompanion allows you to insert responses directly back into the window that was active before activation. This ensures minimal interruption and efficient usage of AI-generated content.

## Hotkey

The current hotkey to trigger AiCompanion is fixed at **Alt + G**. However, adding an option to customize the hotkey is on the development roadmap.

## Getting Started

### Requirements

- **Operating System**: Windows (exclusive)
- **Framework**: .NET Framework 4.8
- **OpenAI API Key**: Required to interact with the OpenAI endpoint.

### Installation

You can download the latest version from the [Releases page](https://github.com/exalsch/AiCompanion/releases).

1. Download and install using the `.msi` installer.  

   **or**

2. Use the binary version by downloading and running the executable directly
   Keep in mind that the app is not yet portable, as user settings are stored in the user's profile folder.

### Usage

1. **Prompt**: Select any text from any application, press the hotkey, and choose the "Prompt" option to send the text to OpenAI. You can also customize pre-prompts for specific types of responses.
   
2. **TTS**: Select the text you want to hear read out, press the hotkey, and choose the "TTS" option to send it to the Text-To-Speech endpoint. Optionally, you can download the audio file.

3. **STT**: Record your voice, then use the "STT" option to transcribe it into text. The transcribed text can be pasted back into your workflow.

## Roadmap

- Customizable hotkey support.
- Portability improvements (removal of dependency on user profile for settings).

## Contributing

Contributions are welcome! Please follow these steps to contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -m "Add a new feature"`).
4. Push to the branch (`git push origin feature-branch`).
5. Open a Pull Request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Contact

For any issues or questions, feel free to open an issue or contact the project maintainer.

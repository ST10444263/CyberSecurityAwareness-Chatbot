# Cybersecurity Awareness Chatbot

Welcome to the **Cybersecurity Awareness Chatbot**! This application is designed to provide guidance on staying safe online, raising awareness about cybersecurity practices, and answering common questions about online safety.

---

## Table of Contents
1. [About the Project](#about-the-project)
2. [Features](#features)
3. [How to Run](#how-to-run)
4. [Usage](#usage)
5. [File Structure](#file-structure)
6. [Contributing](#contributing)
7. [License](#license)

---

## About the Project

The **Cybersecurity Awareness Chatbot** is a simple console-based chatbot written in C#. It interacts with users by responding to their questions about cybersecurity topics such as password safety, phishing, and safe browsing practices. The chatbot also includes a voice greeting and an ASCII art logo to create an engaging user experience.

---

## Features

- **Voice Greeting**: A short audio message plays at the start of the program.
- **ASCII Logo**: A visually appealing logo displayed in the console.
- **Name Validation**: Ensures that users provide a valid name during the initial setup.
- **Interactive Chat**: Users can ask questions on various cybersecurity topics, and the chatbot provides helpful responses.
- **Customizable**: Easily add new topics and responses by extending the chatbot logic.

---

## How to Run

### Prerequisites
- Install the [.NET SDK](https://dotnet.microsoft.com/download) on your system.
- Ensure you have the `.wav` file for the voice greeting located at `C:\Users\Amoge\source\repos\CybeSecurityAwarenessChatBot\greeting (2).wav`. Update the file path in the code if needed.

### Steps to Run
1. Clone the repository or copy the program files to your local machine.
2. Open the project in your preferred IDE (e.g., Visual Studio).
3. Build the solution to ensure there are no errors.
4. Run the program to start the chatbot.

---

## Usage

1. **Start the Chatbot**:
   When the program runs, it will:
   - Play a voice greeting.
   - Display an ASCII art logo.
   - Prompt the user to enter their name.

2. **Chat with the Bot**:
   - Ask questions about cybersecurity topics like:
     - *"password safety"*
     - *"phishing"*
     - *"safe browsing"*
   - You can also have casual conversations with the bot (e.g., "Hello", "How are you?").
   - To exit the program, type `exit`.

3. **Error Handling**:
   - If invalid input is provided (e.g., an empty name or unrecognized question), the bot will prompt the user for clarification.

---

## File Structure
---

CybersecurityAwarenessChatbot/
├── Program.cs # Main program file containing all the chatbot logic
├── greeting.wav # Audio file for the chatbot's voice greeting (not included in the repo)

## Contributing

Contributions are welcome! If you'd like to improve the chatbot, follow these steps:

1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature-name
git commit -m "Add a new feature"
git push origin feature-name

## License
This project is licensed under the MIT License. See the LICENSE file for details.
The MIT License (MIT)

Copyright (c) 2015 Graham Henry

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE

Acknowledgments
ASCII art generated for the chatbot logo.
Audio greeting functionality powered by the System.Media.SoundPlayer library.
Regex name validation inspired by common practices in input sanitization.

Contact
For questions or suggestions, reach out to:

Name: Alexos
GitHub: Amogelang Mokoena
Email: st104442632rcconnect.edu.za

### Notes:
- Replace placeholder values (e.g., `YourGitHubUsername`, `your.email@example.com`) with your actual details.
- Ensure the `greeting.wav` file is located in the correct path or update the file path in the `Program.cs` file.

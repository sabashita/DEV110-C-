# Week 1: Hello, GitHub - Study Notes

**Name:Haiyang Li**

## Development Environment Setup

**Software installed and versions:**
[List each piece of software you installed: .NET SDK, Visual Studio Code, Git, and any VS Code extensions]

Answer:.NET SDK(9.0.308),
        VS Version: 1.106.1 (Universal),
        git version 2.39.5 (Apple Git-154)

**Operating system:**
[What OS are you using? Windows, macOS, or Linux?]

Answer:MacOS

## Challenges and Solutions

**Biggest challenge during setup:**
[What was the hardest part? Installing software, configuring VS Code, understanding the terminal, or something else?]

Answer: reading a ton of documents and notes

**How you solved it:**
[Explain what you did to overcome the challenge - search online, ask for help, restart your computer, etc.]

Answer: search online / ask for help

**Most confusing concept:**
[What was hardest to understand? Git commands, terminal navigation, C# syntax, or dotnet CLI?]

Answer: I didn't use Git before, just wondering how to solve the conflict of file, is there any view interface UI or windows could be handle files, merge, pull. Cause I have used SVN before.

## Understanding C# Basics

**What does `Console.WriteLine()` do?**
[Explain in your own words what this command does]

Answer: Console.WriteLine means output a content of a line in commandLine.

**What is the purpose of `Program.cs`?**
[Why is this file important in a C# project?]

Answer: it's compile by .NET SDK to run a program, it's the main files of C#

**What does `dotnet run` do?**
[Explain what happens when you run this command]

Answer:compile and run the c# files

## Git Workflow Understanding

**What is the difference between `git add`, `git commit`, and `git push`?**
[Explain each command and when you would use it]

Answer:git add: prepare your modified files into the waiting space,it's the preprocessing interval
       git commit: commit your code with comment or message
       git push: push your code to your GitHub repository from local

**Why do we create branches?**
[Explain the purpose of creating a student branch]

Answer: We have to keeping the main branch clean and stable without "bug", cause create branches for test, it won't affecting the main branch

## What I Learned

**Key takeaways from this week:**
[What are the 3 most important things you learned?]

1.Git/GitHub, but no limited, I will research more detail
2.echo 'export PATH="/usr/local/share/dotnet:$PATH"' >> ~/.zshrc && source ~./zshrc && hash -r
(cause I installed the .NET SDK 10.0 by brew, and when I was run the dotnet run command was failed,so that I download the offical .NET SDK 9.0, and run agian, but still couldn't works. Then I search online, it must change the default setting of variable of environment). And another command I learned is "which dotnet", "dotnet --list-runtimes".
git log --oneline --modules/week/....
git show
git checkout main
git status
git branch

3.using the command terminal to run the c# files

**How this connects to professional development:**
[Why are these skills important for programmers?]

Answer: It's important to programmers that because when you participate the team, the code of group will merge together which means collaboration is the most crucial. And code management is also important, backup your code, keeping test/main branch clean and stable is important.

## Time Spent

**Total time:** [8 hours]

**Breakdown:**

-   Installing and configuring software: [10 min]
-   Learning terminal/command line basics: [10 min]
-   Writing the "Hello, GitHub!" program: [5 min]
-   Understanding Git workflow: [3 hours]
-   Testing and fixing issues: [30 hours]
-   Writing documentation: [3-4 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:reading all of thoese document , instructions videos and writing studynotes about 3-4 hours

cause Mac environment was very well, easy to install,it won't took me much time.
To understand Git while reading the instructions took me long time. I have never used befoere even I have sign up the GitHub account long time ago.

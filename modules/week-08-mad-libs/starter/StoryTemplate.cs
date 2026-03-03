/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Haiyang Li
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Represents a Mad Libs story template with prompts and story text.
- */

namespace MadLibs;

public class StoryTemplate
{
    public StoryTemplate(string title, string[] prompts, string templateText)
    {
        Title = title;
        Prompts = prompts;
        TemplateText = templateText;
    }

    public string Title { get; }

    public string[] Prompts { get; }

    public string TemplateText { get; }

    // TODO 1: Implement GenerateStory method
    public string GenerateStory(string[] words)
    {
        if (words == null)
        {
            throw new ArgumentNullException(nameof(words));
        }

        if (words.Length != Prompts.Length)
        {
            throw new NotImplementedException();
        }

        return FormatStory(words);
    }

    // TODO 2: Implement FormatStory method (private helper)
    private string FormatStory(string[] words)
    {
        object[] args = new object[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            args[i] = words[i];
        }

        return string.Format(TemplateText, args);
    }
}

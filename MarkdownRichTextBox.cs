using System;
using System.Drawing;
using System.Windows.Forms;

public class MarkdownRichTextBox : RichTextBox
{
    public void ParseMarkdown()
    {
        // Get the Markdown text from the Text property
        string markdownText = this.Text;

        // Clear the RichTextBox before applying the parsed Markdown
        this.Rtf = "";  // Use Rtf to ensure proper reformatting and clearing


        // Split the text into lines to handle headers and other formatting
        var lines = markdownText.Split(new[] { '\n' }, StringSplitOptions.None);


        foreach (var line in lines)
        {
            // Check for Markdown heading syntax (e.g., # Heading 1)
            if (line.StartsWith("# "))
            {
                // Apply heading formatting (larger font, bold, color)
                this.SelectionFont = new Font("Arial", 14, FontStyle.Bold);
                this.AppendText(line.Substring(2) + Environment.NewLine);
            }
            else if (line.StartsWith("## "))
            {
                // Apply heading formatting (larger font, bold, color)
                this.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                this.AppendText(line.Substring(2) + Environment.NewLine);
            }
            else if (line.StartsWith("##' "))
            {
                // Apply heading formatting (larger font, bold, color)
                this.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
                this.AppendText(line.Substring(2) + Environment.NewLine);
            }
            else
            {
                // Handle bold (**bold**) and italic (*italic*) syntax
                ParseInlineMarkdown(line);
                this.AppendText(Environment.NewLine);
            }
        }
    }

    private void ParseInlineMarkdown(string line)
    {
        int pos = 0;

        while (pos < line.Length)
        {
            int boldStart = line.IndexOf("**", pos);
            int italicStart = line.IndexOf("*", pos);

            // Determine the next Markdown element to process
            if (boldStart == -1 && italicStart == -1)
            {
                // No more markdown syntax, append the rest of the text
                this.AppendText(line.Substring(pos));
                break;
            }

            if (boldStart != -1 && (italicStart == -1 || boldStart < italicStart))
            {
                // Bold formatting: find the matching closing ** pair
                int boldEnd = line.IndexOf("**", boldStart + 2);
                if (boldEnd != -1)
                {
                    // Append text before bold
                    this.AppendText(line.Substring(pos, boldStart - pos));

                    // Apply bold formatting
                    this.SelectionFont = new Font(this.Font, FontStyle.Bold);
                    this.AppendText(line.Substring(boldStart + 2, boldEnd - boldStart - 2));

                    // Move the cursor after the closing **
                    pos = boldEnd + 2;
                }
                else
                {
                    // No matching closing pair, just append the rest of the text
                    this.AppendText(line.Substring(pos));
                    break;
                }
            }
            else if (italicStart != -1)
            {
                // Italic formatting: find the matching closing * pair
                int italicEnd = line.IndexOf("*", italicStart + 1);
                if (italicEnd != -1)
                {
                    // Append text before italic
                    this.AppendText(line.Substring(pos, italicStart - pos));

                    // Apply italic formatting
                    this.SelectionFont = new Font(this.Font, FontStyle.Italic);
                    this.AppendText(line.Substring(italicStart + 1, italicEnd - italicStart - 1));

                    // Move the cursor after the closing *
                    pos = italicEnd + 1;
                }
                else
                {
                    // No matching closing pair, just append the rest of the text
                    this.AppendText(line.Substring(pos));
                    break;
                }
            }
        }
    }
}

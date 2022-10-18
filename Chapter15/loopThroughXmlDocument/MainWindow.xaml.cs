using System.Windows;
using System.Xml;

namespace loopThroughXmlDocument
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\FullStackDevelopment\BeginningCSharpAndDotNET\Chapter15\XML\book.xml");
            textBlockResults.Text =
            FormatText(document.DocumentElement as XmlNode, "", "");

        }

        private string FormatText(XmlNode? node, string text, string indent)
        {

            if (node is XmlText)
            {
                text += node.Value;
                return text;
            }
            if (string.IsNullOrEmpty(indent))
                indent = "";
            else
            {
                text += "\r\n" + indent;
            }
            if (node is XmlComment)
            {
                text += node.OuterXml;
                return text;
            }
            text += "<" + node.Name;
            if (node.Attributes.Count > 0)
            {
                AddAttributes(node, ref text);
            }
            if (node.HasChildNodes)
            {
                text += ">";
                foreach (XmlNode child in node.ChildNodes)
                {
                    text = FormatText(child, text, indent + " ");
                }
                if (node.ChildNodes.Count == 1 &&
                (node.FirstChild is XmlText || node.FirstChild is XmlComment))
                    text += "</" + node.Name + ">";
                else
                    text += "\r\n" + indent + "</" + node.Name + ">";
            }
            else
                text += "/>";
            return text;
        }

        private void AddAttributes(XmlNode node, ref string text)
        {
            foreach (XmlAttribute xa in node.Attributes)
            {
                text += " " + xa.Name + "='" + xa.Value + "'";
            }
        }

        private void buttonCreateNode_Click(object sender, RoutedEventArgs e)
        {
            // Load the XML document.
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\FullStackDevelopment\BeginningCSharpAndDotNET\Chapter15\XML\book.xml");
            // Get the root element.
            XmlElement root = document.DocumentElement;
            // Create the new nodes.
            XmlElement newBook = document.CreateElement("book");
            XmlElement newTitle = document.CreateElement("title");
            XmlElement newAuthor = document.CreateElement("author");
            XmlElement newCode = document.CreateElement("code");
            XmlText title = document.CreateTextNode("Professional C# 7 and .NET Core");
            XmlText author = document.CreateTextNode("Christian Nagel");
            XmlText code = document.CreateTextNode("978-1119449270");
            XmlComment comment = document.CreateComment("the Professional edition");
            // Insert the elements.
            newBook.AppendChild(comment);
            newBook.AppendChild(newTitle);
            newBook.AppendChild(newAuthor);
            newBook.AppendChild(newCode);
            newTitle.AppendChild(title);
            newAuthor.AppendChild(author);
            newCode.AppendChild(code);
            root.InsertAfter(newBook, root.LastChild);
            document.Save(@"C:\FullStackDevelopment\BeginningCSharpAndDotNET\Chapter15\XML\book.xml");
        }


    }
}





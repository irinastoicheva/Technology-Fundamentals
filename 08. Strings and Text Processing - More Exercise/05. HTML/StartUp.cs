namespace _05._HTML
{
    using System;
    using System.Text;

    class StartUp
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();

            string title = Console.ReadLine();
            sb.AppendLine("<h1>");
            sb.Append(" ");
            sb.AppendLine(title);
            sb.Append("</h1>");
            Console.WriteLine(sb);
            sb.Clear();

            string content = Console.ReadLine();
            sb.AppendLine("<article>");
            sb.Append(" ");
            sb.AppendLine(content);
            sb.Append("</article>");
            Console.WriteLine(sb);
            sb.Clear();

            string command = Console.ReadLine();
            while (command != "end of comments")
            {
                string comment = command;
                sb.AppendLine("<div>");
                sb.Append(" ");
                sb.AppendLine(comment);
                sb.Append("</div>");
                Console.WriteLine(sb);
                sb.Clear();

                command = Console.ReadLine();
            }
        }
    }
}

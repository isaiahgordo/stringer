namespace stringer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>greetings = new List<string> {"Hello there ","Ah genral ","It's a bird it's a plane no it's ","Hi ","Hello " }; 
            args = new string[7];
            string fame, lame, stId=" ", ehelp = "@parkside.ca", read=" ",hlp,reverseName,melp;
            int num, i,lelp=0;
            Random r = new Random();
            Console.WriteLine("Enter your first name");
            fame=Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Enter your last name");
            lame=Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Enter your student id");
            stId=Console.ReadLine().Trim();
            for (i = 0; i < args.Length; i++)
            {
                hlp = stId.Substring(0, 3);
                stId.Replace(hlp, " ").Trim();
                args[i] = hlp;
                if (args[i]!=null)
                    lelp++;
            }
            num=r.Next(greetings.Count);
            melp = fame.Substring(0, 4) + lame.Substring(0, 4) + args[args.Length-1] + ehelp;
            Console.WriteLine(greetings[num]+melp);
            reverseName = fame.ToUpper() + lame;
            List<string> letters=new List<string>(reverseName.Length);
            string hello,backward="",same=" ";
            for(i=0;i<letters.Count;i++)
            {
                hello = reverseName.Substring(0,1);
                if(fame.Contains(hello))
                {
                    letters[i]=hello;
                    reverseName.Replace(hello, " ").Trim();
                }
            }
            letters.Reverse();
            for(i=0;i<letters.Count;i++)
            {
                backward =backward+ letters[i];
            }
            Console.WriteLine(backward);
            Console.WriteLine("Type something");
            same = Console.ReadLine().Trim().ToLower();
            read = same;
            for(i=0;i<letters.Count;i++)
            {
                if (i <= read.Length)
                { 
                    hello = read.Substring(0, 1); 
                    letters[i]=hello;
                    read.Replace(hello, " ").Trim();
                }
                else
                    letters.RemoveAt(i);
            }
            letters.Reverse();
            for(i=0;i<letters.Count;i++)
            {
                read=read+letters[i];
            }
            if(read==same)
            {
                Console.WriteLine("It's a palindrome");
            }
            else
                Console.WriteLine(read+" "+same);
        }
    }
}

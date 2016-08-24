using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace High.Quality.Code.BadExample
{
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using System.Threading.Tasks;

    public class Bunnies
    {
        static void Main(string[] args)
        {
            var bunnies = new List<Bunny>
            {
                new Bunny {
                    Name = "Leonid" , Age= 1, FurType = FurType.NotFluffy },
new Bunny { Age= 2, Name = "Rasputin" , FurType = FurType.ALittleFluffy },
                new Bunny
                { FurType = FurType.ALittleFluffy, Name = "Tiberii" , Age= 3, },
                new Bunny
                {
                    Name = "Neron" , FurType = FurType.ALittleFluffy, Age= 1 },
                new Bunny
                { Name = "Klavdii" , Age= 3, FurType = FurType.Fluffy },
                new Bunny
                { Name = "Vespasian" , Age= 3, FurType = FurType.Fluffy },
                new Bunny {Name = "Domician" ,




                    Age = 4, FurType = FurType.FluffyToTheLimit },
                new Bunny {Name = "Tit" , Age= 2,


                    FurType = FurType.FluffyToTheLimit }
            };


            var
consoleWriter =
                // Introduce all bunnies
                new ConsoleWriter();
foreach (
                var bunny

                        in

                bunnies){ bunny.Introduce(consoleWriter); } var  // Create bunnies text file
                bunniesFilePath
                =
                @"..\..\bunnies.txt"; var
                fileStream
                =
                File.Create(bunniesFilePath); fileStream.Close();

            // Save bunnies to a text file
            using (var streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }



    [Serializable] public class Bunny
    {
        public int Age { get; set; } public string Name { get; set; } public FurType FurType { get; set; } public void Introduce(IWriter writer)
        {
            writer.WriteLine($"{this.Name} - \"I am {this.Age} years old!\"");
            writer.WriteLine($"{this.Name} - \"And I am {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");
        } public override string ToString()
        {
            var builderSize = 200;
            var builder = new StringBuilder(builderSize);

            builder.AppendLine($"Bunny name: {this.Name}");
            builder.AppendLine($"Bunny age: {this.Age}");
            builder.AppendLine($"Bunny fur: {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");

            return builder.ToString();
        }
    }

    public enum FurType
    {
        NotFluffy,ALittleFluffy,Fluffy,FluffyToTheLimit
    }

    public
        interface
            IWriter {
        void Write ( string message );
        void WriteLine ( string message );
    }

    public
        class
            ConsoleWriter :
            IWriter
    {
        public void Write(string message)
        {
            Console.Write(message); }
            public void WriteLine(string message) {
            Console.WriteLine(message);
        }
    }

    public static class StringExtensions
    {
        public static string SplitToSeparateWordsByUppercaseLetter(this string sequence)
        {
            var probableStringMargin = 10;
            var probableStringSize = sequence.Length + probableStringMargin;
            var builder = new StringBuilder(probableStringSize);

            var singleWhitespace = ' ';
            foreach (var letter in sequence)
            {
                if (Char.IsUpper(letter))
                {
                    builder.Append(singleWhitespace);
                }

                builder.Append(letter);
            }

            return builder.ToString().Trim();
        }
    }
}

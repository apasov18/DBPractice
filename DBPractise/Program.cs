using Dapper;
using SisNipoGovUa.Data;
using SisNipoGovUa.Implements;
using System.Collections.Generic;

namespace DBPractise
{
    internal class Program
    {
        static async Task  Main(string[] args)
        {
            ParseDecentralizationGovUa parser = new ParseDecentralizationGovUa();

            using (var database = Context.Connect)
            {
                foreach (var data in parser)
                {
                    
                    foreach (var a in data.Data.Areas)
                    {
                        
                        //await Console.Out.WriteLineAsync( a.Title);
                        //await Console.Out.WriteLineAsync(a.SumCommunitiesSquare.ToString());
                        //await Console.Out.WriteLineAsync(a.Population.ToString());



                        await database.ExecuteAsync(@"INSERT INTO Areas VALUES 
                           (@Id, @Title,@Square,@Population,@LocalCommunityCount,@PercentCommunitiesFromArea,@SumCommunitiesSquare)",a);
                    }

                }
            }


        }
    }
}
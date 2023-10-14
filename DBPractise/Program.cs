using Dapper;
using DecentralizationGovUa.Implements;
using SisNipoGovUa.Data;
using SisNipoGovUa.Implements;
using System.Collections.Generic;

namespace DBPractise
{
    internal class Program
    {
        static async Task  Main(string[] args)
        {
             ParseCommunities parser = new ParseCommunities();

            using (var database = Context.Connect)
            {
                foreach (var data in parser)
                {
                    
                    foreach (var a in data.Data.Communities)
                    {

                        //await Console.Out.WriteLineAsync(a.Title);
                        //await Console.Out.WriteLineAsync(a.AreaId.ToString());
                        //await Console.Out.WriteLineAsync(a.Population.ToString());
                        //await Console.Out.WriteLineAsync(a.Koatuu.ToString());
                        
                        await database.ExecuteAsync(@"INSERT INTO Communities VALUES 
                           (@Id,@Title,@Center,@Created,@AreaId,@RegionId,@Population,@Square,@CouncilSize,@DistrictSize,@Koatuu)", a);
                    }

                }
            }


        }
    }
}
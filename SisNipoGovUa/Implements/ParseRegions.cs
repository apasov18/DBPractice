using DecentralizationGovUa.Models;
using Newtonsoft.Json;
using SisNipoGovUa.Enums;
using SisNipoGovUa.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecentralizationGovUa.Implements
{
    public class ParseRegions: IEnumerable<ResponseModel>
    {
        readonly string _url = "https://decentralization.gov.ua/graphql?query={regions{title, area_id,id,population,square}}";

        public async Task<BaseResponse<ResponseModel>> Parse()
        {
            var response = new BaseResponse<ResponseModel>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpContent content = new StringContent("");
                    var responseAsync = await client.PostAsync(_url, content);
                    if (!responseAsync.IsSuccessStatusCode)
                    {
                        throw new Exception();
                    }
                    string json = await responseAsync.Content.ReadAsStringAsync();

                    response.Data = JsonConvert.DeserializeObject<ResponseModel>(json);

                }
            }
            catch (Exception ex)
            {

            }

            return response;
        }

        public IEnumerator<ResponseModel> GetEnumerator()
        {
            var result = Parse();
            result.Wait();
            var response = result.Result;
            if (response.Status == Status.Ok)
            {
                yield return response.Data;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}

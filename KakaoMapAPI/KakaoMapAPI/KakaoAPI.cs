using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


//참조에서 System.web.extension 반드시 추가해야 함

//이것을 추가해야 주소에 반환되는 json을 내가 쓰기 편하게 파싱 가능
namespace KakaoMapAPI
{
    public class KakaoAPI
    {
     public static List<MyLocale> Search(string qstr)
        {
            List<MyLocale> mls = new List<MyLocale>();

            string site = "https://dapi.kakao.com/v2/local/search/keyword.json";
            string query = $"{site}?query={qstr}";
            WebRequest request = WebRequest.Create(query);

            string rKey = "9cf3bc7a91d756cb3fb11b08dadffba7";
            string header = "KakaoAK " + rKey;
            request.Headers.Add("Authorization", header);

            //요청된걸 읽어들이는 작업
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            string json = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();

            //var = foreach 문에서 쓰이는데
            //var는 선언이 되면서 타입이 정해짐

            //일종의 임시변수 
            //dynamic은 임시 객체라고 보면 된다.
            //dynamic은 프로그램이 실행 되어야 타입이 결정됨
            dynamic dob = js.Deserialize<dynamic>(json);//var랑 비슷한 자료형

            //
            dynamic docs = dob["documents"];

            object[] buf = docs;
            int length = buf.Length;


            //장소 이름, 위도 , 경도
            for(int i =0; i<length; i++)
            {
                string lname = docs[i]["place_name"];
                double x = double.Parse(docs[i]["x"]);
                double y = double.Parse(docs[i]["y"]);
                mls.Add(new MyLocale(lname, x, y));
            }

            return mls;
        }
    }
}

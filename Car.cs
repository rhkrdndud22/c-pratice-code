using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice_0610
{
    class Car
    {   //클래스 변수
        public const string JIJUM = "동대구 영업소";
        

        //인스턴스 변수
        
        private string company;
        private string color;
        private string price;
        private string model;
      
        public Car()//기본 생성자
        {
            company = "기아";
            color = "블랙";
            model = "k7";
            price = "4천만원";
        }
        
        public Car(string company,string color, string model, string price)//모든 속성을 매개변수로 
        {                                                                  //전달하여 객체를 생성할수 있는 생성자
            this.company = company;
            this.color = color;
            this.model = model;
            this.price = price;
        }

        public void printCarinfo()//모든 속성들을 출력하는 인스턴스 매소드
        {
            Console.WriteLine(JIJUM);
            
            Console.WriteLine("제조사: " + company);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("모델: " + model);
            Console.WriteLine("가격: " + price);

        }

        public void setModel(string model)//모델명을 설정하는 인스턴스
        {
            this.model = model ;
        }

        public void setPrice(string price)
        {
            this.price = price;
        }

        public string getModel()
        {
            return model;
        }
        public string getPrice()
        {
            return price;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyObserverPattern
{
    public interface iSubject
    {
        void register(iObserver o);//관찰자 추가
        void remove(iObserver o);//관찰자 제거
        void notify();//관찰자들(옵저블들)에게 일괄통지함 함수
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Util
{
    public static  class GenerateHash
    {
        private const string Chrs= "0123456789qwertyuiopasdfghjklzxcvbnm"; 
        public static string MakeHashLink(this string Link){
            string result=string.Empty;
            Random rnd=new Random();
            for(int i=0;i<5;i++){
                int index=rnd.Next(0,Chrs.Length-1);
                result+=Chrs[index];
            }
            return result;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roodom
{
    class Program
    {
        static void Main(string[] args)
        {

            double totalMoney = 50;     //总金额
            int num = 10;           //红包个数
            double minMoney = 0.01;     //红包最小值
            Random ro = new Random();   //实例化random对象
            for (int i = 1; i < num; i++)
            {
                double safaMoney = (totalMoney - (num - i) * minMoney) / (num - i);
                double money = NextDouble(ro, minMoney * 100, safaMoney * 100) / 100; //每次的红包金额
                money = Math.Round(money, 2, MidpointRounding.AwayFromZero);
                totalMoney = totalMoney - money;        //剩余金额
                totalMoney = Math.Round(totalMoney, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine($"第{i}个红包:{money}元，剩余金额{totalMoney}元");
            }
            Console.WriteLine($"第{num}个红包:{totalMoney},剩余金额：0元");
            Console.ReadKey();
        }
        /// <summary>
        /// 生成设置范围内的double的随机数
        /// </summary>
        /// <param name="rand"></param>
        /// <param name="mimDouble">生成随即数的最小值</param>
        /// <param name="maxDouble">生成随即数的最大值</param>
        /// <returns></returns>
        private static double NextDouble(Random rand, double minDouble, double maxDouble)
        {
            if (rand != null)
            {
                return rand.NextDouble() * (maxDouble - minDouble) + minDouble;
            }
            else
            {
                return 0.0d;
            }
        }
    }
}

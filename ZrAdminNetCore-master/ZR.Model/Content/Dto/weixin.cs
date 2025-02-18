using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZR.Model.Content.Dto
{
    public class weixin
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int gender { get; set; }

        public string gender_str { set { if (gender == 1) { gender_str = "男"; } else if (gender == 2) { gender_str = "女"; } else { gender_str = "未知"; } } }

        public string imgUrl { get; set; }

        public DateTime? AdddateTime { get; set; }

        public List<game> games { get; set; }

    }

    public class game
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class weixin_gameSERVICE
    {
        weixin user1 = new weixin()
        {
            gender = 1,
            Id = 1,
            Name = "张三",
            imgUrl = "https://ss1.bdstatic.com/70cFvXSh_Q1YnxGkpoWK1HF6hhy/it/u=1918769464,1587548310&fm=26&gp=0.jpg",
            AdddateTime = DateTime.Now,
            games = new List<game>()
            {
                new game()
                {
                    id=1,
                    name="王者荣耀"
                },
                new game()
                {
                    id=2,
                    name="和平精英",
                }

            }
        };
    }
}
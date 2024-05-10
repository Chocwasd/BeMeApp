﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMIapp.Common
{
    public class Constant
    {
        public static List<PostModel> GetPostModels()
        {
            // create an ArrayList of type Employee class
            List<PostModel> feedList
                = new List<PostModel>();

            PostModel post1 = new PostModel(
                "Edrian V. Visagas",
                "@Chocwasd14",
                "a week ago",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris at finibus sem, malesuada placerat mauris." +
                "Curabitur consectetur augue eget dui feugiat eleifend. Fusce pretium",
                "https://scontent.fceb1-1.fna.fbcdn.net/v/t39.30808-6/436380983_761908692791353_4499806116742752390_n.jpg?stp=dst-jpg_p180x540&_nc_cat=105&_nc_cb=99be929b-ddd1f5c1&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeHhy77Vu8_mfECPoosgAb8rXLSSw_r0V_5ctJLD-vRX_l6V9iP-d-PyWFKwJroF36B83utwm3ZBpz0gEmUOTJuX&_nc_ohc=WB2AYLBF3YEQ7kNvgHM7hnD&_nc_ht=scontent.fceb1-1.fna&oh=00_AYCLv4AMA-y8b6u95Ojnd0m05nRDAen7wdspg5wKYZTRCw&oe=664431F4");

            feedList.Add(post1);

            PostModel post2 = new PostModel(
                 "Edrian V. Visagas",
                "@Chocwasd14",
                "a week ago",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris at finibus sem, malesuada placerat mauris." +
                "Curabitur consectetur augue eget dui feugiat eleifend. Fusce pretium",
                "https://scontent.fceb1-3.fna.fbcdn.net/v/t39.30808-6/441911123_755116593488845_6128594799754334816_n.jpg?_nc_cat=104&_nc_cb=99be929b-ddd1f5c1&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeE82tLK-T08kQvaiS9r0soyXizjW3QMD5VeLONbdAwPlUB3iDzsK_2Qix5EteviBBGqCtQZVEnfYLSZy7Vd0BiL&_nc_ohc=xl23STTLZUcQ7kNvgGK6wgv&_nc_ht=scontent.fceb1-3.fna&oh=00_AYAhpfwILThe5YeKcZHNj7M6FU2nHJ1zOgVJva1px7PT8Q&oe=66441F0F");

            feedList.Add(post2);

            PostModel post3 = new PostModel(
                 "Edrian V. Visagas",
                "@Chocwasd14",
                "a week ago",
                "As we present to you the 𝑺𝒐𝒏𝒐𝒓𝒐𝒖𝒔 𝑩𝒍𝒐𝒐𝒅𝒍𝒊𝒏𝒆 𝑺𝒕𝒓𝒊𝒅𝒆𝒏𝒕, who will be " +
                "leading the event with their captivating drum beats and beautiful sounds.",
                "https://scontent.fceb1-4.fna.fbcdn.net/v/t39.30808-6/441078736_122140935890132343_2234865518469452284_n.jpg?_nc_cat=107&_nc_cb=99be929b-ddd1f5c1&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeH2O1yugfZmx0faZb7TPcCV4IlKbCg6ig3giUpsKDqKDdl3pihRpdPX6IdQZsmXzZNEqtey0yB50Zv0GuIo1Nfl&_nc_ohc=6-uy2YKiyWoQ7kNvgESaUgs&_nc_ht=scontent.fceb1-4.fna&oh=00_AYCan0MNL7pd4C-Qb7bLGfqSbvUCscSVZaQ8saIk8eSCEQ&oe=66443D56");

            feedList.Add(post3);

            PostModel post4 = new PostModel(
                "Edrian V. Visagas",
                "@Chocwasd14",
                "a week ago",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris at finibus sem, malesuada placerat mauris." +
                "Curabitur consectetur augue eget dui feugiat eleifend. Fusce pretium",
                "https://t4.ftcdn.net/jpg/02/21/13/29/360_F_221132937_6X32xmuAeHgS7x6aYshPEnkuIrswoBQk.jpg");

            feedList.Add(post4);


            return feedList;
        }
    }
}
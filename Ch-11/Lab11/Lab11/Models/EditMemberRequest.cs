﻿namespace Lab11.Models
{
    public class EditMemberRequest
    {
        //修改會員資訊的會員編號uid欄位為字串
        public string uid { get; set; }
        //修改會員資訊的會員姓名name欄位為字串
        public string name { get; set; }
        //修改會員資訊的會員電話phone欄位為字串
        public string phone { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Langben.App.Models
{
    /// <summary>
    /// 注册实体
    /// </summary>
    public class RegisterModel
    {
        [Display(Name = "绰号")]
        [Required(ErrorMessage = "不能为空")]       
        [StringLength(200, ErrorMessage = "长度不可超过200")]
        public string Name { get; set; }

        [ScaffoldColumn(true)]
        [Display(Name = "手机号码")]
        [StringLength(200, ErrorMessage = "长度不可超过200")]
        [RegularExpression(@"((\d{11})|^((\d{7,8})|(\d{4}|\d{3})-(\d{7,8})|(\d{4}|\d{3})-(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1})|(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1}))$)", ErrorMessage = "手机格式不正确")]
        //[DataType(System.ComponentModel.DataAnnotations.DataType.PhoneNumber, ErrorMessage = "号码格式不正确")]
        public object PhoneNumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "确认密码")]
        [Compare("Password", ErrorMessage = "密码和确认密码不匹配。")]
        public string ConfirmPassword { get; set; }
       
    }
}
# MVC_With_SimpleLogin

MVC簡易登入  
20210511 第一次上傳，先弄個簡易的登入，之後有空再把功能修一修  
登入頁面 參考: https://codepen.io/colorlib/pen/rxddKy  


創建帳號的table  
USE [test]  
GO  

/****** Object:  Table [dbo].[Account]    Script Date: 2021/5/14 下午 04:43:10 ******/  
SET ANSI_NULLS ON  
GO  

SET QUOTED_IDENTIFIER ON  
GO  

CREATE TABLE [dbo].[Account](  
	[Index] [int] IDENTITY(1,1) NOT NULL,  
	[Name] [varchar](20) NOT NULL,  
	[Password] [nvarchar](50) NOT NULL,  
	[Createtime] [datetime] NOT NULL  
) ON [PRIMARY]  
GO  

ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Account_Createtime]  DEFAULT (getdate()) FOR [Createtime]
GO  


###########################  
INSERT Account VALUES ('Ann', 'aaa', GETDATE())  --自行新增


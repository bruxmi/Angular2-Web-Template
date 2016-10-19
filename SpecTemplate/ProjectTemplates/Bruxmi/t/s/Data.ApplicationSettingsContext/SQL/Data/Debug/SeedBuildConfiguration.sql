-- ConnectionString
INSERT [dbo].[ConnectionString] ([Name], [Value], [ProviderName]) VALUES (N'AppSettingContext', N'Server=(localdb)\ProjectsV12; Database=Debug.AppSettingContext; Trusted_Connection=True; Timeout=60; MultipleActiveResultSets=True;', N'System.Data.SqlClient')

-- ApplicationSetting
INSERT [dbo].[ApplicationSetting] ([Key], [Value]) VALUES (N'LogLevel', N'Debug')
INSERT [dbo].[ApplicationSetting] ([Key], [Value]) VALUES (N'LogMode', N'Database')

SET IDENTITY_INSERT [dbo].[Course] ON
INSERT INTO [dbo].[Course] ([Id], [course_Name], [start_date], [end_date], [course_duration]) VALUES (1, N'Web development', N'2021-02-01 09:00:00', N'2021-06-01 09:00:00', N'2')
SET IDENTITY_INSERT [dbo].[Course] OFF
SET IDENTITY_INSERT [dbo].[Student] ON
INSERT INTO [dbo].[Student] ([Id], [student_Name], [student_Email], [student_Mobile], [student_Address], [CourseId]) VALUES (1, N'Johan', N'johan@gmail.com', N'45678923', N'Papatoetoe', 1)
SET IDENTITY_INSERT [dbo].[Student] OFF

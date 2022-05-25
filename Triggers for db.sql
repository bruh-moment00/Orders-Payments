USE [OrdersPaymentsDB]
GO

/****** Object:  Trigger [dbo].[FOR_NEW_ORDER]    Script Date: 25.05.2022 23:59:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER trigger [dbo].[FOR_NEW_ORDER] on [dbo].[ORDERS]
after insert 
as
update ORDERS
set paidSum = 0
GO

ALTER TABLE [dbo].[ORDERS] ENABLE TRIGGER [FOR_NEW_ORDER]
GO

USE [OrdersPaymentsDB]
GO

/****** Object:  Trigger [dbo].[FOR_NEW_FUND]    Script Date: 25.05.2022 23:59:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER trigger [dbo].[FOR_NEW_FUND] on [dbo].[FUNDS]
after insert 
as
update FUNDS
set remain = [sum]
GO

ALTER TABLE [dbo].[FUNDS] ENABLE TRIGGER [FOR_NEW_FUND]
GO


USE [OrdersPaymentsDB]
GO

/****** Object:  Trigger [dbo].[NEW_PAYMENT_LIMITS]    Script Date: 26.05.2022 0:00:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER trigger [dbo].[NEW_PAYMENT_LIMITS] on [dbo].[PAYMENTS]
after insert
as begin
	declare @paymentSum float, @orderSum float, @orderPaidSum float, @fundRemain float
	select @paymentSum = paymentSum from inserted
	select @orderSum = [sum] from ORDERS where id = (select orderId from inserted)
	select @orderPaidSum = paidSum from ORDERS where id = (select orderId from inserted)
	select @fundRemain = remain from FUNDS where id = (select fundId from inserted)

	if (@paymentSum) + (@orderPaidSum) > (@orderSum) or (@paymentSum) > (@fundRemain)
	begin
		rollback tran
		print 'Ошибка, оплачиваемое значение превышает остаток средств или превышает сумму оплаты заказа'
	end
end
GO

ALTER TABLE [dbo].[PAYMENTS] ENABLE TRIGGER [NEW_PAYMENT_LIMITS]
GO


USE [OrdersPaymentsDB]
GO

/****** Object:  Trigger [dbo].[NEW_PAYMENT_UPDATE_FUNDS]    Script Date: 26.05.2022 0:00:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER trigger [dbo].[NEW_PAYMENT_UPDATE_FUNDS] on [dbo].[PAYMENTS]
after insert
as 
update FUNDS
set remain = remain - (select paymentSum from inserted) where id = (select fundId from inserted)
GO

ALTER TABLE [dbo].[PAYMENTS] ENABLE TRIGGER [NEW_PAYMENT_UPDATE_FUNDS]
GO


USE [OrdersPaymentsDB]
GO

/****** Object:  Trigger [dbo].[NEW_PAYMENT_UPDATE_ORDERS]    Script Date: 26.05.2022 0:00:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER trigger [dbo].[NEW_PAYMENT_UPDATE_ORDERS] on [dbo].[PAYMENTS]
after insert
as 
update ORDERS
set paidSum = paidSum + (select paymentSum from inserted) where id = (select orderId from inserted)
GO

ALTER TABLE [dbo].[PAYMENTS] ENABLE TRIGGER [NEW_PAYMENT_UPDATE_ORDERS]
GO



set identity_insert tblDeTai on 


create procedure InsertDT
	@madetai int,
	@tendetai nvarchar(150),
	@loaidetai nchar(30)
as
begin
	insert into tblDeTai
	(maDetai, tenDetai, loaiDetai )
	values
	(@madetai, @tendetai, @loaidetai);
	IF @@ROWCOUNT>0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;
end

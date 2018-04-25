<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DataBase.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CodeFirst_in_DataBase</title>
</head>
<body>
    <div class="form">
        <form id="form1" runat="server" enctype="multipart/form-data">
            
                <div class="data">

                    <div>
                        <label>Name</label>
                        <input name="firstName" />
                    </div>

                    <div>
                        <label>Surname</label>
                        <input name="surname" />
                    </div>
                    <div>
                        <label>PassportCode</label>
                        <input name="passportCode" />
                    </div>
                    <div>
                        <label>Expirience</label>
                        <input name="experience" />
                    </div>

                    <div>
                        <label>Characteristic</label>
                        <input name="characteristic" />
                    </div>
                    <div>
                        <label>army</label>
                        <input name="army" />
                    </div>
                    
                    <div>
                        <label>Фото</label>
                        <input type="file" name="photo" />
                    </div>
                    
                    <input type="submit" value="InsertInDB" />

                </div>


            
        </form>
    </div>
    <style>
        .form { position: absolute; left: 50%; width: 470px; margin-left: -235px; background: #888; border-radius: 5px; top: 20px; }
        form { background: #fff; border-radius: 2px;  margin: 5px;  }
        .data { border-top: 1px solid #d5d5d5; padding: 10px 15px; }
        .data div { margin: 8px 0; }
        h3 { padding: 10px 15px; margin: 0; }
        label { min-width: 100px; display: block; float: left; }
        input[type="submit"] { margin-top: 10px; }
    </style>
</body>
</html>

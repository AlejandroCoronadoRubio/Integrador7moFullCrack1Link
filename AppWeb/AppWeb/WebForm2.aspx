<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="AppWeb.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Bienvenido a nordson</title>
    <style type="text/css">

        .auto-style1 {
            width: 99%;
            height: 88px;
        }

    </style>


        <link href="css/menu.css" rel="stylesheet" type="text/css"/>
        <link href="css/encabezado.css" rel="stylesheet" type="text/css"/>
        <link href="css/about.css" rel="stylesheet" type="text/css"/>
        <link href="css/redes.css" rel="stylesheet" type="text/css"/>
    
    </head>
    <body>
        <nav>

            <span id="logotipo">Nordson Medical</span>
            
        </nav>
        <header>
            
        </header>     
        <section>
            <div>
                <h2>SOLICITUD DE MATERIALES</h2>
            </div>
            <div>
                <div id="formulario">
                    <form action="#">
                        <table >
                            <tr>
                                <td>COMPONENTE</td>
                                <td>NOTAS</td>
                            </tr>
                            <tr>
                                <td>
                                    <select name="componente">

                                        <option>COMPONENTE1</option>
                                        <option>COMPONENTE2</option>
                                        <option>COMPONENTE3</option>
                                        <option>COMPONENTE4</option>
                                        <option>COMPONENTE5</option>
                                        <option>COMPONENTE6</option>
                                        <option>COMPONENTE7</option>
                                        <option>COMPONENTE8</option>
                                        <option>COMPONENTE9</option>

                                   </select>    
                                </td>
                                <td rowspan="3">
                                    <textarea name="message"></textarea>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    CANTIDAD
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <input type="number" name="cantidad" placeholder="Ingrese la cantidad"/>
                                </td>
                            </tr>
                            <tr>
                                <td>AREA</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <select name="area">

                                        <option>PVC1</option>
                                        <option>PVC2</option>
                                        <option>PVC3</option>
                                        <option>PVC4</option>
                                        <option>PVC5</option>
                                        <option>PVC6</option>
                                        <option>PVC7</option>
                                        <option>PU1</option>
                                        <option>PU2</option>

                                   </select>                    
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <input type="submit" value="ENVIAR SOLICITUD"/>
                                </td>
                            </tr>
                        </table>
                    </form>
                </div>
               
            </div>
        </section>
        <footer>
            
        </footer>
    </body>
</html>

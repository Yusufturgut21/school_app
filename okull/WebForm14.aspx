<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm14.aspx.cs" Inherits="okull.WebForm14" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css" integrity="sha512-z3gLpd7yknf1YoNbCzqRKc4qyor8gaKU1qmn+CShxbuBusANI9QpRohGBreCFkKxLhei6S9CQXFEbbKuqLg0DA==" crossorigin="anonymous" referrerpolicy="no-referrer" />

    <title>YEMEK MENÜ</title>
     <style type="text/css">
         body{
             background-color:blue;
         }
         
.menu .box-container{
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(30rem, 1fr)); /*ortaladı display: grid sayesinde*/
    gap: 2rem;

}
.menu .box-container .box{
    padding: 3rem;
    background-color: red;
    border-radius: 3rem;
    box-sizing:1rem;
}



.menu .box-container .box .menu-category{
    font-size: 1.5rem;
    text-transform: uppercase;
    color:white;
    cursor:pointer;
       
    
}
.menu .box-container .box h3{
    font-size: 3rem;
    padding: 1rem 0;
    color:white;

}
.card{
    display:flex;
    justify-content:center;

}





         </style>

</head>
<body>
         <!-- Image and text -->
<nav class="navbar navbar-light bg-danger">
  <a class="navbar-brand bg-danger " href="https://localhost:44353/WebForm4">
      <svg xmlns="http://www.w3.org/2000/svg" width="35" height="35" fill="currentColor" class="bi bi-book-half" viewBox="0 0 16 16">
  <path d="M8.5 2.687c.654-.689 1.782-.886 3.112-.752 1.234.124 2.503.523 3.388.893v9.923c-.918-.35-2.107-.692-3.287-.81-1.094-.111-2.278-.039-3.213.492V2.687zM8 1.783C7.015.936 5.587.81 4.287.94c-1.514.153-3.042.672-3.994 1.105A.5.5 0 0 0 0 2.5v11a.5.5 0 0 0 .707.455c.882-.4 2.303-.881 3.68-1.02 1.409-.142 2.59.087 3.223.877a.5.5 0 0 0 .78 0c.633-.79 1.814-1.019 3.222-.877 1.378.139 2.8.62 3.681 1.02A.5.5 0 0 0 16 13.5v-11a.5.5 0 0 0-.293-.455c-.952-.433-2.48-.952-3.994-1.105C10.413.809 8.985.936 8 1.783z"/>
</svg>
    E-BİLGİ
  </a>
    </nav>


    <div class="card mb-3 ">
        <img src="https://www2.beu.edu.tr/Dosya/MenuYemek.png"  alt="...">
        </div>






      <section class="menu">
       
        <div class="box-container">
            <div class="box ">
               
                <span class="menu-category">Tepsi Kebabı / Fırın Tavuk / Etli Patates</span>
                <h3>
                   PAZARTESİ
                </h3>
               
              
            </div>
            <div class="box">
               
                <span class="menu-category">Tavuk Sote / Etli Kuru Fasülye / Terbiyeli Köfte</span>
                <h3>
                    SALI
                </h3>
               
                <div class="box-bottom">
                 
                </div>
            </div>
            <div class="box">
               
                <span class="menu-category">Tavuk Döner / Orman Kebap / Etli Güveç</span>
                <h3>
                    ÇARŞAMBA
                </h3>
              
                <div class="box-bottom">
                  
                </div>
            </div>
            <div class="box">
                
                <span class="menu-category">Tavuk Haşlama / Etli Nohut / Patlıcan Musakka</span>
                <h3>
                    PERŞEMBE
                </h3>
                
                <div class="box-bottom">
                   
                </div>
            </div>
              <div class="box">
      
      <span class="menu-category">Tavuk Roti / İzmir Köfte / Biber Dolma</span>
      <h3>
          CUMA
      </h3>
     
      <div class="box-bottom">
        
      </div>
  </div>
                        <div class="box">
   
    <span class="menu-category">Pirinç Pilavı / Spagetti Makarna /Cacık</span>
    <h3>
        CUMARTESİ
    </h3>
   
    <div class="box-bottom">
       
    </div>
</div>

            
        </div>

       </section>

</body>
</html>

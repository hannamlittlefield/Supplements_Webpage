body {
  background:linear-gradient(45deg, rgba(47,79,79,1) 22%, rgba(0,139,139,1) 70%);text-align:center;
  
}
.main {
  align-content: center;
  text-align: center;
  font-family:  garamond;
  margin: auto;
   -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
}

#img-header {
  display: block;
  margin-left: auto;
  margin-right: auto;
  max-width: 50%;
  border: 3px solid #adadad;
  border-radius: 25px;
  filter: drop-shadow(10px 10px 4px black);
}

.h1{
  font-family: 'Prata', serif;
}

.main-box {
  
  border: 3px solid #adadad;
  border-radius: 25px;
  box-shadow: 10px 10px 4px black;
  width: 900px;
  padding: 30px;
  margin: auto;
  font-family:  arial;
  text-align: center;
  background-color: white;

}

.flex-supplements {
  display: flex;
  flex-direction: row;
  justify-content: space-around;
  width: 900px;
  padding: 30px;
  border: 3px solid #adadad;
  border-radius: 25px;
  box-shadow: 10px 10px 4px black;
  justify-content: center;
  margin: auto;
}

#footer {
  font-size: 13px;
  font-family: arial;
}



.flex-supplements {
  display: flex;
  flex-direction: row;
  width: 900px;
  padding: 20px;
  border: 3px solid #adadad;
  border-radius: 25px;
  box-shadow: 10px 10px 4px black;
  justify-content: center;
  margin: auto;
}

.container{
  padding: 1em 0;
  float: left;
  width: 50%;
  background-color: white;
}

.content {
  position: relative;
  width: 100%;
  max-width: 200px;
  margin: auto;
  overflow: hidden;
}

.content .content-overlay {
  background: rgba(0,0,0,0.7);
  position: absolute;
  height: 99%;
  width: 100%;
  left: 0;
  top: 0;
  bottom: 0;
  right: 0;
  opacity: 0;
  -webkit-transition: all 0.4s ease-in-out 0s;
  -moz-transition: all 0.4s ease-in-out 0s;
  transition: all 0.4s ease-in-out 0s;
}

.content:hover .content-overlay{
  opacity: 1;
}

.content-image{
  width: 75%;
  border: 3px solid #adadad;
  border-radius: 25%;
  padding: 5px;
}

.b12-image{
  width: 95%;
  border: 3px solid #adadad;
  padding: 2px;
  border-radius: 25%;
}


.content-details {
  position: absolute;
  text-align: center;
  padding-left: 1em;
  padding-right: 1em;
  width: 100%;
  top: 50%;
  left: 50%;
  opacity: 0;
  -webkit-transform: translate(-50%, -50%);
  -moz-transform: translate(-50%, -50%);
  transform: translate(-50%, -50%);
  -webkit-transition: all 0.3s ease-in-out 0s;
  -moz-transition: all 0.3s ease-in-out 0s;
  transition: all 0.3s ease-in-out 0s;
}

.content:hover .content-details{
  top: 50%;
  left: 50%;
  opacity: 1;
}


.content-details p{
  color: black;
  font-size: 15px;
  background-color: white ;
  font-family: arial;
  padding: 5px;
}


.fadeIn-top{
  top: 50%;
}

a:link {
  text-decoration: none;
  color: bl
    

* {
    border: 0;
    box-sizing: border-box;
    margin: 0;
  }
  .container{
    height: content;
    width: 100%;
    justify-content: center;
    align-items: center;
    display: flex;
    flex-flow: column;
  }
  .head-nav {
    height:30px;
    width:100%;
    background-color: green;
    display:flex;
    justify-content: center;
    align-items: center;
    padding: 8px;
  }
  .logo-heading {
    height: 250px;
    width: 250px;
    margin-top: -20px;
    justify-content: center;
    align-items: center;
    display: flex;
  }
  .logo-heading img {
    height: 100%;
    width: 100%;
  }
  .container-data {
    height: 200px;
    width: 100%;
    justify-content: center;
    display: flex;
    align-items: center;
    background-color:rgb(236, 214, 214);
    flex-flow: column;
    margin-top: -40px;
    padding-left: 10px;
    padding-right: 10px;
  }
.text-box {
    height: 40px;
    width:90%;
    border-radius: 5px;
    border: 2px solid green;
    background-color: rgb(252, 248, 248);
    margin-top: 15px;
    font-size: 16px;
    font-weight: bold;
}
.btn {
    height: 35px;
    width:100px;
    border-radius: 5px;
    border: 2px solid black;
    background-color: green;
    color: white;
    margin-top: 15px;
  }

.btn:hover {
    color: white;
    background-color:red;
    cursor: pointer;
}
.show-result {
    height: content;
    width: 100%;
    display: flex;
    justify-content: center;
    flex-flow: column wrap;
    background-color: rgb(252, 243, 243);
    margin-bottom: 50px;
    margin-top: -30px;
    padding: 30px;
}
.output {
    height: 40px;
    width: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    font-size: 19px;
    font-weight: 300;
    font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    color: red;
    margin-top: 3px;
}
.output-desc {
  height: 40px;
  width: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  font-size: 18px;
  font-weight: 300;
  font-family:Arial, Helvetica, sans-serif;
  color: blue;
  margin-top: 3px;
}
.output-logo {
  height: 100px;
  width: 100%;
  margin-top:20px;
  justify-content: center;
  display: flex;
  align-items: center;
}
.output-logo img {
  height: 100%;
  widt
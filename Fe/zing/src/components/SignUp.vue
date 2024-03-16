<template>
    <div id="SignUp">
        <div id= "bg1">
            <h1>Sign Up</h1>
            <div id="username">
                <div class="input-group">
                    <img src="@/assets/iconUser.png" alt="Icon Name" class="input-icon">
                    <input type="text" v-model="username" @focus="clearUsername" placeholder="Username" class="input-field">
                </div>
            </div>
            
            <div id="password">
                <div class="input-group">
                    <img src="@/assets/iconPass.png" alt="Icon Pass" class="input-icon">
                    <input type="password" v-model="password" placeholder="Password">
                </div>
            </div>
            <div id="email">
                <div class="input-group">
                    <img src="@/assets/image 7.png" alt="Icon Email" class="input-icon">
                    <input type="email" v-model="email" placeholder="Email" pattern="[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$" title="Please enter a valid email address" class="input-field">
                </div>
            </div>
            <div id="phone">
                <div class="input-group">
                    <img src="@/assets/image 8.png" alt="Icon Phone" class="input-icon">
                    <input type="tel" v-model="phone" placeholder="Phone" pattern="[0-9]{10}" title="Please enter a 10-digit phone number" class="input-field">
                </div>
            </div>
            <button class="SUbutton" @click="signUp">SIGN UP</button>
        </div>
        <div id="bg2">
            <img src="@/assets/image 6.png" alt="Icon" class="music">
            <h1>Welcome to HGTV!</h1>
            <p class="details">Already have an account?</p>
            <button class="SIbutton" @click="signIn"> SIGN IN</button>
        </div>
    </div>
  </template>
  
  <script>
    export default {
      data() {
        return {
          username: '',
          password: '',
          showPassword: false,
          email: '',
          phone: '',
        };
      },
      methods: {
        clearUsername() {
          this.username = '';
        },
        signIn() {
            this.$router.push('/');
        },
        signUp() {
            // Kiểm tra dữ liệu email và số điện thoại
            if (!this.validateEmail(this.email)) {
                alert('Please enter a valid email address.');
                return;
            }
            if (!this.validatePhone(this.phone)) {
                alert('Please enter a valid phone number.');
                return;
            }
            // Đoạn mã xử lý khi người dùng click vào nút Sign Up
            },
            validateEmail(email) {
            // Kiểm tra định dạng email
            const regex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
            return regex.test(email);
            },
            validatePhone(phone) {
            // Kiểm tra định dạng số điện thoại (10 chữ số)
            const regex = /^\d{10}$/;
            return regex.test(phone);
            }
  }
    }

  </script>
  
  <style>
      
    #SignUp{
      display: grid;
      grid-template-columns: 1fr 1fr;
      position: relative;
      text-align: center; 
      
    }
  
    #bg1{
      background-color: #F9F9F9;
      box-shadow: 0px 8px 16px rgba(0, 0, 0, 0.5);
      z-index: 2;
      position: relative;
      justify-content: center; 
      align-items: center; 
      width: 450px; 
      height: 600px; 
      border-radius: 50px;
      margin: 15% 0 0 27%;
      display: flex; 
      flex-direction: column;
    }
  
    .username i{
      padding-left: 0;
    }
  
    .username input {
      padding-left: 30px; 
    }
  
    .password input {
      padding-right: 40px; 
    }
  
    #bg1 h1, #bg2 h1 {
      padding-bottom: 5%;
      font-size: 60px; 
      font-family: Inter,sans-serif; 
      font-weight: bold; 
      
    }
  
    input[type="text"], input[type="password"] {
      height: 43px; 
      margin-bottom: 20px; 
      border-radius: 5px;
      font-size: 18px;
      background-color: #E3E2E2;
      border: none;
      padding-left: 50px;
      font-family: Inter,sans-serif; 
      font-weight: lighter;
    }
  
    input[type="text"]:focus, input[type="password"]:focus {
      border: 1px solid #000 ;
      outline: none;
      
    } 
  
    .input-group {
    position: relative;
  }
  
  .input-icon {
    position: absolute;
    top: 15%;
    left: 15px; 
    width: 20px; 
    height: auto; 
  }
  
   .input-field {
    padding-left: 30px; 
  } 
  
  #email input, #phone input {
    height: 43px; 
    margin-bottom: 20px; 
    border-radius: 5px;
    font-size: 18px;
    background-color: #E3E2E2;
    border: none;
    padding-left: 50px;
    font-family: Inter,sans-serif; 
    font-weight: lighter;
    }

    #email input:focus, #phone input:focus {
        border: 1px solid #000 ;
        outline: none;
    }

  
    .SUbutton, .SIbutton {
      width: 170px;
      height: 55px; 
      padding: 10px 20px;
      font-size: 23px;
      border: none;
      border-radius: 30px;
      cursor: pointer;
      transition: background-color 0.3s ease; 
      background-color: #563a74;
      color: #F9F9F9;
    }
  
    .SUbutton{
        margin-top: 15px ;
    }
    .SUbutton:hover {
      background-color: #170F23; 
    }
  
    #bg2{
      background-color: #170F23;
      z-index: 1; 
      color:#F9F9F9;
      box-shadow: 0px 8px 16px rgba(0, 0, 0, 0.5);
      position: relative;
      justify-content: center; 
      align-items: center; 
      border-radius: 50px;
      width: 620px;
      height: 650px;
      padding-top: 5%;
      margin: 10% 0 0 -20%;
      text-align: center;
    }
  
    #bg2 .music{
      float: right;
      padding-right: 10px;
    }
  
    #bg2 h1{
      /* width: 500px; */
      padding: 25% 0 0 2%;
      font-size: 50px;
    }
  
    #bg2 p{
      font-size: 20px;
      font-family: Inter, sans-serif;
      font-weight: lighter;
      margin: 0 0 10% 20%; 
      width: 400px;
  
      }
  </style>
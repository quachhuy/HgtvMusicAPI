<template>
    <div id="container">
      <div id="index">
        <div id="logo">
            <img src="@/assets/image 9.png" alt="Icon" class="">
            <h1>hgtv</h1>
            <h3>music</h3>
        </div>
        <div id="type">
          <div id="user">
            <img src="@/assets/image 13.png" alt="Icon User" class="icon">
            <router-link to="/manage" class="router-link" id="user-manager">User Manager</router-link>
          </div>
          <div id="content">
            <img src="@/assets/image 16.png" alt="Icon Content" class="icon">
            <router-link to="/content" class="router-link" id="content-manager">Content Manager</router-link>
            <ul v-if="showDropdown">
              <li><router-link to="/content/song" class="router-link" >Song</router-link></li>
              <li><router-link to="/content/playlist" class="router-link" >Playlist</router-link></li>
              <li><router-link to="/content/album" class="router-link" >Album</router-link></li>
            </ul>
          </div>
          <div id="logout">
            <img src="@/assets/image 18.png" alt="Icon LogOut" class="icon">
            <router-link to="/content" id="logout">User Manager</router-link>
          </div>
          
        </div>
      </div>
      <div id="table">

      </div>
    </div>
</template>
  
<script>
  export default {
  data() {
    
  },
  methods: {
    
  }
}
</script>
  
<style >
    #container{
      display: grid;
      grid-template-columns: 1fr 4fr;
    }

    #logo{
      margin-bottom: 30%;
    }
    
    #logo h1{
      font-family: 'Inconsolata', monospace;
      font-weight: bold !important;
      font-size: 80px;
      margin: 0 0 0 20%;
    }
    
    #logo img{
      padding: 5% 0 0 5%;
    }

    #logo h3{
      float: right;
      padding-right: 25%;
      font-size: 23px;
      margin: 0;
      font-family: 'Inter', sans-serif; 
      font-weight: 300;
    }

    #user{
      width: 260px;
      height: 50px;
      display: flex;
      align-items: center;
      justify-content: center;
      border-radius: 5px;
      background: #d9d9d98a;
    }


    .icon{
      width: 35px; 
      height: auto; 
    }

    #user-manager{
      padding-left: 20px;
      text-decoration-line: none;
      font-size: 20px;
      font-family: 'Inter', sans-serif;
      font-weight: 500;
      color:black;
      
    }
    
    .router-link {
      text-decoration: none;
      color: black;
      font-size: 20px;
      font-family: 'Inter', sans-serif;
      font-weight: 500;
    }


    #table{
      background-color: #331F51;
    }

</style>
  
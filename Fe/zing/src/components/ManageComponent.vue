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
          <router-link to="/manage" class="router-link" id="content-manager">Content Manager</router-link>
          <img src="@/assets/image 17.png" alt="Icon Dropdown" class="icondd">
        </div>
        <div id="song">
          <img src="@/assets/image 12.png" alt="Icon Song" class="icons">
          <router-link to="/manage" class="router-link" id="song-m">Song</router-link>
        </div>
        <div id="playlist">
          <img src="@/assets/image 14.png" alt="Icon PlayList" class="iconp">
          <router-link to="/manage" class="router-link" id="playlist-m">Playlist</router-link>
        </div>
        <div id="album">
          <img src="@/assets/image 15.png" alt="Icon Album" class="icona">
          <router-link to="/manage" class="router-link" id="album-m">Album</router-link>
        </div>
        <div id="logout">
          <img src="@/assets/image 18.png" alt="Icon LogOut" class="icono">
          <router-link to="/manage" class="router-link" id="logout-m">Log Out</router-link>
        </div>
      </div>
    </div>
    <div id="dashboard">
      <div class="header">
        <div class="search">
          <input type="search" v-model="search" placeholder="Search" @input="searchUser" @keydown.enter="handleSearchEnter">
          <img src="@/assets/image 21.png" alt="Avatar" class="avatar">
        </div>
        <div class="welcome">
          <p class="welcome1">Welcome, Giao !</p>
          <p class="view">View report about the user manager</p>
        </div>
        <button @click="createUser" class="create-user"> + Create New User</button>
      </div>
      <div class="table-manage">
        <table class="user-table">
        <thead>
          <tr>
            <th>ID</th>
            <th>Username</th>
            <th>Email</th>
            <th>Phone</th>
            <th>Action</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="(user, index) in users" :key="index">
            <td>{{ user.id }}</td>
            <td>{{ user.username }}</td>
            <td>{{ user.email }}</td>
            <td>{{ user.phone }}</td>
            <td>
              <button @click="editUser(user.id)">Edit</button>
              <button @click="deleteUser(user.id)">Delete</button>
            </td>
          </tr>
        </tbody>
      </table>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      search: '',
      users: [
        { id: 1, username: 'JohnDoe', email: 'john@example.com', phone: '123-456-7890' },
        { id: 2, username: 'JaneDoe', email: 'jane@example.com', phone: '987-654-3210' },
      ]
    };
  },
  methods: {
    searchUser() {
      console.log('Searching for:', this.search);
    },
    createUser() {
      console.log('Creating new user...');
    },
    editUser(userId) {
      console.log('Editing user with ID:', userId);
    },
    deleteUser(userId) {
      console.log('Deleting user with ID:', userId);
    },
    handleSearchEnter(event) {
      if (event.key === 'Enter') {
        this.searchUser();
      }
    }
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

  #type{
    padding-top: 13%;
  }

  #user, 
  #content{
    width: 260px;
    height: 50px;
    display: flex;
    align-items: center;
    justify-content: center;
    border-radius: 5px;
    margin-bottom: 10%;
  }

  #user{
    background: #d9d9d98a;
  }

  #content .icon{
    padding-right: 7px;
  }

  .icondd{
    padding-left: 5px;
  }

  .icon, .icons, .iconp, .icona, .icono, .iconse{
    width: 35px; 
    height: auto; 
  }

  .icons, .iconp, .icona, .icono{
    padding-right: 7%;
  }

  #user-manager{
    padding-left: 20px;
    text-decoration-line: none;
    font-size: 20px;
    font-family: 'Inter', sans-serif;
    font-weight: 500;
    color:black;
    
  }

  #song, 
  #playlist,
  #album{
    width: 260px;
    height: 50px;
    display: flex;
    align-items: center;
    justify-content: center;
    border-radius: 5px;
    margin-bottom: 7%;
  }
  
  #logout{
    margin-top: 15%;
    width: 200px;
    height: 50px;
    display: flex;
    align-items: center;
    justify-content: center;
  }

  .router-link {
    text-decoration: none;
    color: black;
    font-size: 20px;
    font-family: 'Inter', sans-serif;
    font-weight: 500;
  }

  #dashboard{
    background-color: #331f51bf;
    margin: 2% 2% 0 0;
    height: 750px;
    border-radius: 65px;
  }

  .search{
    float: right;
    margin: 5% 5% 0 0;
    display: flex;
    align-items: center;
    justify-content: center;
  }

  .avatar{
    width:45px;
    height: auto;
    padding-left: 3%;
  }

  input[type="search"]{
    border-radius: 25px;
    width: 200px;
    height: 37px; 
    font-size: 18px;
    background-color: #E3E2E2;
    border: none;
    padding-left: 50px;
    font-family: Inter,sans-serif; 
    font-weight: lighter;
  }

  .welcome{
    padding: 10% 0 0 7%;
  }

  .welcome1{
    font-family: 'Kodchasan', sans-serif;
    font-weight: bold !important;
    font-size: 45px;
    margin-bottom: 0;
  }

  .view, .create-user{
    font-family: Inter,sans-serif; 
    font-weight:400;
    font-size: 15px;
  }

  .create-user{
    width: 220px;
    height: 40px; 
    font-size: 15px;
    border: none;
    float:right;
    border-radius: 5px;
    cursor: pointer;
    transition: background-color 0.3s ease; 
    background-color: #E3E2E2;
    color: #000000;
    margin-right: 10%;

  }

  .create-user:hover {
    background-color: #cbc8c8; 
  }

  .table-manage{
    padding-top: 10%;
  }
</style>

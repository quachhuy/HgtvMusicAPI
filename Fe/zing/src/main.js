import { createApp } from 'vue';
import App from './App.vue';
import SignIn from './components/SignIn.vue';
import SignUp from './components/SignUp.vue'; 
import ManageComponent from './components/ManageComponent.vue';
import { createRouter, createWebHistory } from 'vue-router';

const app = createApp(App);

const router = createRouter({
  history: createWebHistory(),
  routes: [
    { path: '/', component: SignIn },
    { path: '/signup', component: SignUp },
    { path: '/manage', component: ManageComponent },
  ]
});

app.use(router);

app.mount('#app');

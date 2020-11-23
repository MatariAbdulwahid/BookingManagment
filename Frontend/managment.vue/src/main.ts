import '@babel/polyfill'
import 'mutationobserver-shim'
import { createApp } from 'vue';
import Vue from 'vue'
import './plugins/bootstrap-vue'
import App from './App.vue'
import router from './router'
 
 
createApp(App).use(router).mount('#app')

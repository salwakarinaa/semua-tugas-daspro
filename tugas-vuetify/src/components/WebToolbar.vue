<template>
  <v-toolbar id="toolbar" dark>
    <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
    <div>
      <router-link to="/home">
         <v-btn text>Home</v-btn>
      </router-link>
      <v-btn text>Profile</v-btn>
      <v-btn text>Unit/Lembaga</v-btn>
      <v-btn text>Akademik</v-btn>
      <v-btn text>Dokumen</v-btn>
      <v-btn text>Gallery</v-btn>
      <v-btn text>Peta</v-btn>
      <v-btn text>Video Profile</v-btn>
      <router-link to="/login">
          <v-btn text>Kontak</v-btn>
      </router-link>
    </div>
    <div class="hidden-sm-and-down">
    <v-navigation-drawer
     v-model="drawer"
     absolute
     temporary
     height="800px">
     <v-list class="pa-1">         
        <v-layout column align-center>
        <v-list-item-avatar>
          <img src="https://randomuser.me/api/portraits/men/85.jpg">
        </v-list-item-avatar>

        <v-list-item-content>
          <v-list-item-title>John Leider</v-list-item-title>
        </v-list-item-content>
      </v-layout>
    </v-list>  
    <v-list>
        <v-divider></v-divider>  
        <v-list-item
           v-for="item in items"
           :key="item.title"
           link>
        <v-list-item-icon>
          <v-icon>{{ item.icon }}</v-icon>
        </v-list-item-icon>
        
        <v-list-item-content>
          <v-list-item-title>{{ item.title }}</v-list-item-title>
        </v-list-item-content>
        </v-list-item>
     </v-list>
    </v-navigation-drawer>
    </div>
  </v-toolbar>
</template>

<script>
export default {
  data () {
      return {
        drawer: null,
        items: [
          { title: 'Home', icon: '@mdi-home', },
          { title: 'About', icon: '@mdi-help', }
        ]
      }
  }
}
</script>

<style>
 #toolbar {
  background-color: darkgreen;
 }
 .v-btn {
  color: white !important;
  background-color: darkgreen !important;
 }
</style>
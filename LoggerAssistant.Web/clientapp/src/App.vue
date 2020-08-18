<template>
  <v-app>
    <v-app-bar 
      absolute
      color="#C80046"
      elevate-on-scroll
      scroll-target="#scrolling-techniques-7"
    >

      <v-container class="mx-auto py-0">
        <v-row align="center">
          <v-toolbar-title>Title</v-toolbar-title>

          <v-btn
          class="hidden-sm-and-down"
          text
        >
          Hello
        </v-btn>

          <v-spacer></v-spacer>

          <v-btn icon>
              <v-icon>mdi-magnify</v-icon>
          </v-btn>
        </v-row>
      </v-container>


    </v-app-bar>

    <v-main>
      <HelloWorld/>
    </v-main>
  </v-app>
</template>

<style scoped>
.v-app-bar{

}
</style>

<script>
import HelloWorld from './components/HelloWorld';

export default {
  name: 'App',

  components: {
    HelloWorld,
  },

  data: () => ({
    //
  }),
};
</script>

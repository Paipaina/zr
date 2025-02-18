<template>
  <div id="app">
    <router-view />
    <StudentSearchTabs />
  </div>
</template>

<script>
import { mapGetters } from "vuex";
export default {
  name: "App",
  components: {
  },
  computed: {
    ...mapGetters(["token"]),
  },
  watch: {
    token: {
      handler: function (val) {
        if (val) {
          this.signalr.start();
        }
      },
      deep: true,
      immediate: true,
    },
  },
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>
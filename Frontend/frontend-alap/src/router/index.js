import { createRouter, createWebHistory } from "vue-router";
import HomeView from "../views/HomeView.vue";
import RateView from "../views/RateView.vue";


const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: "/",
      name: "home",
      component: HomeView,
    },
    {
      path: "/rate",
      name: "rate",
      component: RateView,
    },
  ],
});

export default router;

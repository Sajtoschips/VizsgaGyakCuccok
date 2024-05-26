<script setup>
import dataservice from "../services/dataservice.js";
import { ref } from "vue";

const watches = ref([]);
const actPage = ref(1);
const lastPage = ref();
const searchString = ref("")

dataservice
  .getAllWatches(1, searchString.value)
  .then((resp) => {
    watches.value = resp.data;
    lastPage.value = Math.ceil(resp.headers["x-total-count"]/10)
    console.log(lastPage.value);
  })
  .catch((err) => {
    console.log(err);
  });

const lep = (hova) => {
  actPage.value = hova;
  dataservice
    .getAllWatches(hova, searchString.value)
    .then((resp) => {
      watches.value = resp.data;
      console.log(watches.value);
    })
    .catch((err) => {
      console.log(err);
    });
};

const search = () => {
  actPage.value = 1
  dataservice
  .getAllWatches(1, searchString.value)
  .then((resp) => {
    watches.value = resp.data;
    lastPage.value = Math.ceil(resp.headers["x-total-count"]/10)
    console.log(lastPage.value);
  })
  .catch((err) => {
    console.log(err);
  });
}
</script>

<template>
  <div class="container">
    <h1 class="text-center">Lapozás</h1>

    <div class="d-flex justify-content-center">
      <input type="text" class="form-control" name="" v-model="searchString" @keyup="search" id="">
      <button class="btn btn-primary" @click="search">Keresés</button>
    </div>

    <nav
      class="d-flex justify-content-center"
      aria-label="Page navigation example"
    >
      <ul class="pagination">
        <li class="page-item" v-if="actPage > 1">
          <a @click="lep(actPage - 1)" class="page-link" href="#">Previous</a>
        </li>
        <li class="page-item" v-if="actPage > 1">
          <a @click="lep(actPage - 1)" class="page-link" href="#">{{
            actPage - 1
          }}</a>
        </li>
        <li class="page-item">
          <a class="page-link" href="#">{{ actPage }}</a>
        </li>
        <li class="page-item" v-if="actPage < lastPage">
          <a @click="lep(actPage + 1)" class="page-link" href="#">{{
            actPage + 1
          }}</a>
        </li>
        <li class="page-item" v-if="actPage < lastPage">
          <a @click="lep(actPage + 1)" class="page-link" href="#">Next</a>
        </li>
      </ul>
    </nav>

    <div class="row">
      <div v-for="watch in watches" class="col-12 col-md-6 col-xl-4">
        <div class="card w-100">
          <div class="card-body">
            <h5 class="card-title">{{ watch.Model }}</h5>
            <p class="card-text">{{ watch.Price_USD }}</p>
            <p class="text-center mb-0">
              <a href="vote.html" class="btn btn-primary">Vote</a>
            </p>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

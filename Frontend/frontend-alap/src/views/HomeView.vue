<script setup>
import DataService from "../services/dataservice";
import { ref } from "vue";


const locations = ref([]);
const viewpoints = ref([])
const locationId = ref(1)
const maxPage = ref(1)
const limit = ref(1);
const page = ref(1);



DataService.getAllLocations()
  .then((resp) => {
    locations.value = resp;
    console.log(locations.value);
  })
  .catch((err) => {
    console.log(err);
  });



const valaszto = (actualPage) => {
  console.log(maxPage.value);
  if (actualPage <= 0 || actualPage > maxPage.value) {
    return
    
  }
  page.value = actualPage;
  DataService.getById(locationId.value, actualPage, limit.value)
    .then((resp) => {
      console.log(actualPage);
      maxPage.value = Math.ceil(resp.headers["x-total-count"] / limit.value);
      viewpoints.value = resp.data;
      console.log(viewpoints.value);
    })
    .catch((err) => {
      console.log(err);
    })
};
valaszto(page.value)

</script>

<template>
  <div class="form">
    <div class="data">
      <label for="location">Hegység:</label>
      <select name="locationId" id="location" v-model="locationId" @change="valaszto(page)">
        <option value="">Kérem válasszon</option>
        <option :value="location._id" v-for="location in locations">{{ location.locationName }}</option>

      </select>
    </div>
  </div>

  <div id="viewpoints">
    <div class="viewpoint" v-for="viewpoint in viewpoints">
      <h2>{{ viewpoint.viewpointName }}</h2>
      <div>
        <ul>
          <li>
            <label>Hegység:</label>
            <span>{{ viewpoint.mountain }}</span>
          </li>
          <li>
            <label>Magassága:</label>
            <span>{{ viewpoint.height }}</span>
          </li>
          <li>
            <label>Épült:</label>
            <span>{{ viewpoint.built }}</span>
          </li>
        </ul>
      </div>
      <p class="description">
        {{ viewpoint.description }}
      </p>
      <div class="image">
        <img src="https://vizsga2023.cluster.jedlik.eu/images/avas.jpg">
      </div>
    </div>

    
  </div>
  <div class="d-flex justify-content*center">
    <button @click="valaszto(page - 1)">le</button>
    <p>{{ page  }}</p>
    <button @click="valaszto(page + 1)">Fel</button>

  </div>



</template>

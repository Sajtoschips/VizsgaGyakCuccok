<template>
      <h1 class="text-center">Kilátók értékelése</h1>
    <div class="form">

        <div class="data">
            <label for="viewpoint">Kilátó:</label>
            <select name="viewpointId" id="viewpoint" v-model="kilato.viewpointId">
                <option value="">Kérem válasszon</option>
                <option value="8">Avasi kilátó (Avas)</option>
                <option value="2">Julianus-kilátó (Hegyes-tető)</option>
                <option value="11">Kékestetői tévétorony (Kékes)</option>
                <option value="7">Petőfi-kilátó (Bálvány)</option>
                <option value="14">Vörös-kő kilátó (Vörös-kő)</option>
            </select>
        </div>

        <div class="data">
            <label for="email">Az Ön e-mail címe:</label>
            <input v-model="kilato.email" type="text" id="email" name="email">
        </div>

        <div class="data">
            <label for="rating">Értékelés:</label>
            <input v-model="kilato.rating" type="range" min="1" max="10" id="rating" name="rating">
        </div>

        <div class="data">
            <label for="rating">Megjegyzsés:</label>
            <textarea v-model="kilato.comment" id="comment" name="comment" rows="3"></textarea>
        </div>

        <div class="data">
            <input v-model="kilato.acceptedConditions" type="checkbox" id="acceptedConditions" name="acceptedConditions">
            <label  for="acceptedConditions">Felhasználási feltételeket elfogadom</label>
        </div>

        <div class="data">
            <input @click="send" type="button" value="Küldés" style="margin: 0 220px; width: 160px;">
        </div>


        <div class="error">
            <span>Hiányos adatok...</span>
            <span>x</span>
        </div>
    </div>
   
</template>

<script setup>

import DataService from "../services/dataservice";
import { ref } from "vue";

// posthoz
const kilato = ref({
    viewpointId: "",
    email: "",
    rating: "",
    comment: "",
    acceptedConditions: false
});
 const send = () =>{
    DataService.rate(kilato.value)
 }

  





</script>
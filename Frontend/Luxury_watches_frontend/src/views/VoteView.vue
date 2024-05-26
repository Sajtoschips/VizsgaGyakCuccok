<template>
<div class="container">
        <h1 class="text-center">Voting</h1>


        <div class="form col-10 offset-1 col-md-8 offset-md-2 col-lg-6 offset-lg-3 my-4">

            <div class="mb-3">
                <label for="car" class="form-label">Selected car:</label>
                <select id="car" class="form-select">
                    <option value="">Please select</option>
                    <option value="1">Alfa Romeo Tonale</option>
                    <option value="2">BMW X1/iX1</option>
                    <option value="15">Mercedes-AMG SL</option>
                    <option value="21">Peugeot 408</option>
                    <option value="24">Toyota Aygo X</option>
                </select>
            </div>

            <div class="mb-3">
                <label for="email" class="form-label">Your e-mail address:</label>
                <input type="text" class="form-control" id="email">
            </div>
       
            <div class="mb-3">
                <label for="comment" class="form-label">Comment:</label>
                <textarea id="comment" class="form-control" rows="3"></textarea>
            </div>
    
            <div class="mb-3">
                <input type="checkbox" id="acceptedConditions" class="form-check-input" >
                <label for="acceptedConditions" class="form-check-label">Accept terms of use</label>
            </div>
    
            <div class="mb-3 text-center">
                <input type="button" value="Vote" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#successfullVoteModal">
            </div>
    
    
            <div class="alert alert-danger alert-dismissible fade show" role="alert">
                Please accept the terms of use!
                <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
            </div>
    </div>

    <div class="modal fade" id="successfullVoteModal" tabindex="-1">
        <div class="modal-dialog">
          <div class="modal-content">
            <div class="modal-header mx-auto">
              <h5 class="modal-title text-center">Your vote has been successfully registered</h5>
            </div>
            <div class="modal-footer mx-auto">
              <a class="btn btn-secondary" href="car-list.html">Back to list</a>
            </div>
          </div>
        </div>
      </div>
</template>
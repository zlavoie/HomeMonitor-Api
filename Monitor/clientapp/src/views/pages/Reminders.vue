<script setup>
import { ref } from 'vue';

const selectedMonths = ref([
    { name: 'Every 1 month', code: 1},
    { name: 'Every 2 months', code: 2},
    { name: 'Every 3 months', code: 3},
    { name: 'Every 4 months', code: 4},
    { name: 'Every 5 months', code: 5},
    { name: 'Every 6 months', code: 6},
    { name: 'Every 7 months', code: 7},
    { name: 'Every 8 months', code: 8},
    { name: 'Every 8 months', code: 9},
    { name: 'Every 10 months', code: 10},
    { name: 'Every 11 months', code: 11},
    { name: 'Every 12 months', code: 12},
]);
const selectedMonth = ref(null);
const lastServicedDate = ref(null);
const nameForReminder = ref(null);
const upcCode = ref(null);


</script>
<template>
    <div class="grid p-fluid">
        <div class="col-12">
            <form @submit.prevent="handleSubmit(!v$.$invalid)" class="p-fluid">
                <div class="card">
                    <h3>Create Reminder</h3>
                    <br>
                    <div class="grid formgrid">
                        <div class="col-12 mb-2 lg:col-4 lg:mb-0">
                            <span class="p-float-label">
                                <InputText id="reminderName" type="text" v-model="nameForReminder" />
                                <label for="reminderName">Name for Reminder</label>
                            </span>
                        </div>
                        <div class="col-12 mb-2 lg:col-4 lg:mb-0">
                            <span class="p-float-label">
                                <Dropdown v-model="selectedMonth" :options="selectedMonths" optionLabel="name" optionValue="code" placeholder="Frequncy in Months" />
                                <label for="dropdown">Remind me</label>
                            </span>
                        </div>
                        <div class="col-12 mb-2 lg:col-4 lg:mb-0">
                            <span class="p-float-label">
                                <Calendar id="lastService" v-model="lastServicedDate" inputId="icon" :showIcon="true" />
                                <label for="lastService">Last Serviced On</label>
                            </span>
                        </div>
                    </div>
                    <Divider />
                    <h5>Optional</h5>
                    <p>You can link an item to the new reminder</p>
                    <br>
                    <div class="grid formgrid">
                        <div class="col-12 mb-2 lg:col-4 lg:mb-0">
                            <span class="p-float-label">
                                <InputText id="upcCode" type="text" v-model="upcCode" />
                                <label for="upcCode">UPC Code</label>
                            </span>
                        </div>
                    </div>
                    <br><br>
                    <div class="grid formgrid">
                        <div class="col-12 mb-2 lg:col-4 lg:mb-0">
                            <Button type="submit" label="Submit" class="mt-2" />
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</template>

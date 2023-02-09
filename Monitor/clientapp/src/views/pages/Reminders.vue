<script setup>
import { ref, onMounted } from 'vue';
import CountryService from '@/service/CountryService';
import NodeService from '@/service/NodeService';

const floatValue = ref(null);
const autoValue = ref(null);
const selectedAutoValue = ref(null);
const autoFilteredValue = ref([]);
const calendarValue = ref(null);
const inputNumberValue = ref(null);
const chipsValue = ref(null);
const treeSelectNodes = ref(null);
const countryService = new CountryService();
const nodeService = new NodeService();
const selectedMonths = ref([
    { name: '1 month', code: 1},
    { name: '2 months', code: 2},
    { name: '3 months', code: 3},
    { name: '4 months', code: 4},
    { name: '5 months', code: 5},
    { name: '6 months', code: 6},
    { name: '7 months', code: 7},
    { name: '8 months', code: 8},
    { name: '8 months', code: 9},
    { name: '10 months', code: 10},
    { name: '11 months', code: 11},
    { name: '12 months', code: 12},
]);
const selectedMonth = ref(null);

onMounted(() => {
    countryService.getCountries().then((data) => (autoValue.value = data));
    nodeService.getTreeNodes().then((data) => (treeSelectNodes.value = data));
});

const searchCountry = (event) => {
    setTimeout(() => {
        if (!event.query.trim().length) {
            autoFilteredValue.value = [...autoValue.value];
        } else {
            autoFilteredValue.value = autoValue.value.filter((country) => {
                return country.name.toLowerCase().startsWith(event.query.toLowerCase());
            });
        }
    }, 250);
};
</script>
<template>
    <div class="grid p-fluid">
        <div class="col-12">
            <div class="card">
                <h5>Create Reminder</h5>
                <br>
                <div class="grid formgrid">
                    <div class="col-12 mb-2 lg:col-4 lg:mb-0">
                        <span class="p-float-label">
                            <Dropdown v-model="selectedMonth" :options="selectedMonths" optionLabel="name" optionValue="code" placeholder="Select Frequency in Months" />
                            <label for="dropdown">Repeat reminder</label>
                        </span>
                    </div>
                </div>

                <h5>Icons</h5>
                <div class="grid formgrid">
                    <div class="col-12 mb-2 lg:col-4 lg:mb-0">
                        <span class="p-input-icon-left">
                            <i class="pi pi-user" />
                            <InputText type="text" placeholder="Username" />
                        </span>
                    </div>
                    <div class="col-12 mb-2 lg:col-4 lg:mb-0">
                        <span class="p-input-icon-right">
                            <InputText type="text" placeholder="Search" />
                            <i class="pi pi-search" />
                        </span>
                    </div>
                    <div class="col-12 mb-2 lg:col-4 lg:mb-0">
                        <span class="p-input-icon-left p-input-icon-right">
                            <i class="pi pi-user" />
                            <InputText type="text" placeholder="Search" />
                            <i class="pi pi-search" />
                        </span>
                    </div>
                </div>

                <h5>Float Label</h5>
                <span class="p-float-label">
                    <InputText id="username" type="text" v-model="floatValue" />
                    <label for="username">Username</label>
                </span>

                <h5>Textarea</h5>
                <Textarea placeholder="Your Message" :autoResize="true" rows="3" cols="30" />

                <h5>AutoComplete</h5>
                <AutoComplete placeholder="Search" id="dd" :dropdown="true" :multiple="true" v-model="selectedAutoValue" :suggestions="autoFilteredValue" @complete="searchCountry($event)" field="name" />

                <h5>Calendar</h5>
                <Calendar :showIcon="true" :showButtonBar="true" v-model="calendarValue"></Calendar>

                <h5>Spinner</h5>
                <InputNumber v-model="inputNumberValue" showButtons mode="decimal"></InputNumber>

                <h5>Chips</h5>
                <Chips v-model="chipsValue" />
            </div>
        </div>

    </div>
</template>

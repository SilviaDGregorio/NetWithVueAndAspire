<script setup lang="ts">


interface ImageItem { url: string; description: string; }

const { data: images } = await useFetch<ImageItem[]>('/api/images');
</script>

<template>
  <div class="page-images">
    <h1>Images</h1>

    <div v-if="pending">Loading…</div>
    <div v-else-if="error">
      <p>Error loading images: {{ error.message || error }}</p>
    </div>
    <div v-else>
      <div v-if="images && images.length">
        <div class="grid">
          <div v-for="item in images" :key="item.url" class="card">
            <img :src="item.url" :alt="item.description" />
            <p>{{ item.description }}</p>
          </div>
        </div>
      </div>
      <div v-else>
        <p>No images found.</p>
      </div>
    </div>
  </div>
</template>

<style scoped>
.page-images .grid {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(220px, 1fr));
  gap: 16px;
}
.page-images .card {
  border: 1px solid #e6e6e6;
  padding: 8px;
  border-radius: 6px;
  text-align: center;
}
.page-images img {
  max-width: 100%;
  height: auto;
  display: block;
  margin-bottom: 8px;
  border-radius: 4px;
}
</style>

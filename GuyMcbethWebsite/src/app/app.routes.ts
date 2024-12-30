import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { BlogComponent } from './blog/blog.component';
import { GiftComponent } from './gift/gift.component';
import { ContactComponent } from './contact/contact.component';
import { PhotoComponent } from './photo/photo.component';

export const routes: Routes = [
  { path: "", component: HomeComponent, title: "GuyMcBeth.com" },
  { path: "blog", component: BlogComponent, title: "Blog - GuyMcBeth.com" },
  { path: "gifts", component: GiftComponent, title: "Gifts - GuyMcBeth.com" },
  { path: "contact", component: ContactComponent, title: "Contact - GuyMcBeth.com" },
  { path: "photos", component: PhotoComponent, title: "Photos - GuyMcBeth.com" }  
];

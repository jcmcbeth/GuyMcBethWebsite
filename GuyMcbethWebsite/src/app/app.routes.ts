import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { GiftComponent } from './gift/gift.component';
import { ContactComponent } from './contact/contact.component';
import { LinksComponent } from './links/links.component';

export const routes: Routes = [
  { path: "", component: HomeComponent, title: "GuyMcBeth.com" },
  { path: "gifts", component: GiftComponent, title: "Gifts - GuyMcBeth.com" },
  { path: "contact", component: ContactComponent, title: "Contact - GuyMcBeth.com" },
  { path: "links", component: LinksComponent, title: "School Links - GuyMcBeth.com" }
];

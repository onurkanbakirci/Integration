"use strict";(self.webpackChunkintegration=self.webpackChunkintegration||[]).push([[329],{3772:(e,t,n)=>{n.r(t),n.d(t,{assets:()=>d,contentTitle:()=>s,default:()=>u,frontMatter:()=>o,metadata:()=>i,toc:()=>l});var r=n(5893),a=n(1151);const o={sidebar_position:2},s="Trendyol Integration",i={id:"marketplaces/trendyol",title:"Trendyol Integration",description:"Integrate your services with trendyol",source:"@site/docs/marketplaces/trendyol.md",sourceDirName:"marketplaces",slug:"/marketplaces/trendyol",permalink:"/Integration/docs/marketplaces/trendyol",draft:!1,unlisted:!1,editUrl:"https://github.com/facebook/docusaurus/tree/main/packages/create-docusaurus/templates/shared/docs/marketplaces/trendyol.md",tags:[],version:"current",sidebarPosition:2,frontMatter:{sidebar_position:2},sidebar:"tutorialSidebar",previous:{title:"Hepsiburada Integration",permalink:"/Integration/docs/marketplaces/hepsiburada"},next:{title:"Payment Gateways",permalink:"/Integration/docs/category/payment-gateways"}},d={},l=[{value:"How to use",id:"how-to-use",level:2},{value:"Get all categories",id:"get-all-categories",level:3},{value:"Get all brands",id:"get-all-brands",level:3},{value:"Filter products",id:"filter-products",level:3}];function c(e){const t={admonition:"admonition",code:"code",h1:"h1",h2:"h2",h3:"h3",p:"p",pre:"pre",strong:"strong",...(0,a.a)(),...e.components};return(0,r.jsxs)(r.Fragment,{children:[(0,r.jsx)(t.h1,{id:"trendyol-integration",children:"Trendyol Integration"}),"\n",(0,r.jsx)(t.p,{children:"Integrate your services with trendyol"}),"\n",(0,r.jsx)(t.h2,{id:"how-to-use",children:"How to use"}),"\n",(0,r.jsx)(t.pre,{children:(0,r.jsx)(t.code,{className:"language-bash",children:"dotnet add package Integration.Marketplaces.Trendyol\n"})}),"\n",(0,r.jsx)(t.p,{children:"Configure your credentials which are given by trendyol"}),"\n",(0,r.jsx)(t.pre,{children:(0,r.jsx)(t.code,{className:"language-csharp",children:'using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration;\n\nvar trendyolProductIntegration = new TrendyolProductIntegration(\n        supplierId: "supplierId",\n        apiKey: "apiKey",\n        apiSecret: "apiSecret",\n        isInProduction: false,\n        entegratorFirm: "entegratorFirm");\n'})}),"\n",(0,r.jsx)(t.admonition,{type:"tip",children:(0,r.jsxs)(t.p,{children:["You have to get your ",(0,r.jsx)(t.strong,{children:"supplierId"}),", ",(0,r.jsx)(t.strong,{children:"apiKey"})," and ",(0,r.jsx)(t.strong,{children:"apiSecret"})," from trendyol."]})}),"\n",(0,r.jsx)(t.h3,{id:"get-all-categories",children:"Get all categories"}),"\n",(0,r.jsx)(t.pre,{children:(0,r.jsx)(t.code,{className:"language-csharp",children:"var categories = await trendyolProductIntegration.GetCategoryTreeAsync();\n"})}),"\n",(0,r.jsx)(t.h3,{id:"get-all-brands",children:"Get all brands"}),"\n",(0,r.jsx)(t.pre,{children:(0,r.jsx)(t.code,{className:"language-csharp",children:"var brands = await trendyolProductIntegration.GetBrandsAsync();\n"})}),"\n",(0,r.jsx)(t.h3,{id:"filter-products",children:"Filter products"}),"\n",(0,r.jsx)(t.p,{children:"Get values of category attribute"}),"\n",(0,r.jsx)(t.pre,{children:(0,r.jsx)(t.code,{className:"language-csharp",children:'var productFilter = new ProductFilterBuilder()\n    .AddApprovalStatus(true)\n    .AddBarcode("barcode")\n    .AddStartDate(0)\n    .AddEndDate(0)\n    .AddPage(1)\n    .AddSize(10)\n    .AddSupplierId(0)\n    .Build();\n\nvar products = await trendyolProductIntegration.FilterProductsAsync(productFilter);\n'})})]})}function u(e={}){const{wrapper:t}={...(0,a.a)(),...e.components};return t?(0,r.jsx)(t,{...e,children:(0,r.jsx)(c,{...e})}):c(e)}},1151:(e,t,n)=>{n.d(t,{Z:()=>i,a:()=>s});var r=n(7294);const a={},o=r.createContext(a);function s(e){const t=r.useContext(o);return r.useMemo((function(){return"function"==typeof e?e(t):{...t,...e}}),[t,e])}function i(e){let t;return t=e.disableParentContext?"function"==typeof e.components?e.components(a):e.components||a:s(e.components),r.createElement(o.Provider,{value:t},e.children)}}}]);
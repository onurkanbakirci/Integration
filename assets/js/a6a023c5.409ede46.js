"use strict";(self.webpackChunkintegration=self.webpackChunkintegration||[]).push([[842],{6494:(e,n,a)=>{a.r(n),a.d(n,{assets:()=>o,contentTitle:()=>i,default:()=>p,frontMatter:()=>s,metadata:()=>c,toc:()=>l});var t=a(5893),r=a(1151);const s={sidebar_position:2},i="Sipay Integration",c={id:"payment-gateways/sipay",title:"Sipay Integration",description:"Integrate your services with sipay",source:"@site/docs/payment-gateways/sipay.md",sourceDirName:"payment-gateways",slug:"/payment-gateways/sipay",permalink:"/Integration/docs/payment-gateways/sipay",draft:!1,unlisted:!1,editUrl:"https://github.com/facebook/docusaurus/tree/main/packages/create-docusaurus/templates/shared/docs/payment-gateways/sipay.md",tags:[],version:"current",sidebarPosition:2,frontMatter:{sidebar_position:2},sidebar:"tutorialSidebar",previous:{title:"Paynet Integration",permalink:"/Integration/docs/payment-gateways/paynet"}},o={},l=[{value:"Get installments",id:"get-installments",level:3},{value:"Non secure payment",id:"non-secure-payment",level:3},{value:"Secure payment",id:"secure-payment",level:3},{value:"Cancel payment",id:"cancel-payment",level:3},{value:"Refund payment",id:"refund-payment",level:3}];function d(e){const n={admonition:"admonition",code:"code",h1:"h1",h3:"h3",li:"li",ol:"ol",p:"p",pre:"pre",strong:"strong",...(0,r.a)(),...e.components};return(0,t.jsxs)(t.Fragment,{children:[(0,t.jsx)(n.h1,{id:"sipay-integration",children:"Sipay Integration"}),"\n",(0,t.jsx)(n.p,{children:"Integrate your services with sipay"}),"\n",(0,t.jsx)(n.pre,{children:(0,t.jsx)(n.code,{className:"language-bash",children:"dotnet add package Integration.PaymentGateways.Sipay\n"})}),"\n",(0,t.jsx)(n.p,{children:"Configure your credentials which are given by sipay"}),"\n",(0,t.jsx)(n.pre,{children:(0,t.jsx)(n.code,{className:"language-csharp",children:'using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Request;\n\nvar sipayPaymentIntegration = new SipayPaymentIntegration(\n    merchantKey: "merchantKey",\n    appKey: "appKey",\n    appSecret: "appSecret",\n    merchantId: 0,\n    isInProduction: false\n);\n'})}),"\n",(0,t.jsx)(n.admonition,{type:"tip",children:(0,t.jsxs)(n.p,{children:["You have to get your ",(0,t.jsx)(n.strong,{children:"merchantKey"}),", ",(0,t.jsx)(n.strong,{children:"appKey"}),", ",(0,t.jsx)(n.strong,{children:"appSecret"}),", ",(0,t.jsx)(n.strong,{children:"merchantId"})," from sipay."]})}),"\n",(0,t.jsx)(n.h3,{id:"get-installments",children:"Get installments"}),"\n",(0,t.jsx)(n.pre,{children:(0,t.jsx)(n.code,{className:"language-csharp",children:'var installments = await sipayPaymentIntegration.CheckInstallmentsAsync(new CheckInstallmentRequestModel(\n    creaditCard: "123456",\n    amount: 100,\n    currenyCode: "TRY"\n));\n'})}),"\n",(0,t.jsx)(n.h3,{id:"non-secure-payment",children:"Non secure payment"}),"\n",(0,t.jsx)(n.pre,{children:(0,t.jsx)(n.code,{className:"language-csharp",children:'var nonSecurePaymentResponse = await sipayPaymentIntegration.NonSecurePaymentAsync(new NonSecurePaymentRequestModel(\n    ccHolderName: "John Doe",\n    ccNo: "123456",\n    expiryMonth: 12,\n    expiryYear: 2022,\n    cvv: 123,\n    currencyCode: "TRY",\n    installmentsNumber: 1,\n    invoiceId: 1,\n    invoiceDescription: "Invoice description",\n    name: "John",\n    surname: "Doe",\n    total: 100,\n    items: "items",\n    cancelUrl: "https://cancelUrl.com",\n    returnUrl: "https://returnUrl.com",\n    hashKey: "hashKey",\n    ip: "",\n    orderType: 0\n));\n'})}),"\n",(0,t.jsx)(n.h3,{id:"secure-payment",children:"Secure payment"}),"\n",(0,t.jsx)(n.p,{children:"Secure payment consist of 3 phases:"}),"\n",(0,t.jsxs)(n.ol,{children:["\n",(0,t.jsx)(n.li,{children:(0,t.jsx)(n.strong,{children:"Get secure payment initial"})}),"\n"]}),"\n",(0,t.jsx)(n.pre,{children:(0,t.jsx)(n.code,{className:"language-csharp",children:'var securePaymentInitialHtml = sipayPaymentIntegration.SecurePaymentInitial(new SecurePaymentInitialRequestModel(\n    ccHolderName: "John Doe",\n    ccNo: "123456",\n    expiryMonth: 12,\n    expiryYear: 2022,\n    cvv: 123,\n    currencyCode: "TRY",\n    installmentsNumber: 1,\n    invoiceId: "1",\n    invoiceDescription: "Invoice description",\n    name: "John",\n    surname: "Doe",\n    total: 100,\n    items: "items",\n    cancelUrl: "https://cancelUrl.com",\n    returnUrl: "https://returnUrl.com",\n    hashKey: "hashKey",\n    orderType: 0,\n    recurringPaymentNumber: 0,\n    recurringPaymentCycle: "",\n    recurringPaymentInterval: "",\n    recurringWebHookKey: "",\n    maturityPeriod: 0,\n    paymentFrequency: 0\n));\n'})}),"\n",(0,t.jsxs)(n.ol,{start:"2",children:["\n",(0,t.jsx)(n.li,{children:(0,t.jsx)(n.strong,{children:"Show 3ds html content to user"})}),"\n"]}),"\n",(0,t.jsx)(n.pre,{children:(0,t.jsx)(n.code,{className:"language-csharp",children:"Console.WriteLine(securePaymentInitialHtml);\n"})}),"\n",(0,t.jsxs)(n.ol,{start:"3",children:["\n",(0,t.jsx)(n.li,{children:(0,t.jsx)(n.strong,{children:"After successfull 3d confirmation, secure payment charge"})}),"\n"]}),"\n",(0,t.jsx)(n.pre,{children:(0,t.jsx)(n.code,{className:"language-csharp",children:'var securePaymentChargeRequest = await sipayPaymentIntegration.SecurePaymentChargeAsync(new SecurePaymentChargeRequestModel(\n    invoiceId: "1",\n    orderId: "1",\n    status: "1",\n    hashKey: ""));\n'})}),"\n",(0,t.jsx)(n.h3,{id:"cancel-payment",children:"Cancel payment"}),"\n",(0,t.jsx)(n.pre,{children:(0,t.jsx)(n.code,{className:"language-csharp",children:'var cancelResponse = await sipayPaymentIntegration.CancelAsync(new CancellationRequestModel(\n    invoiceId: "",\n    hashKey: "",\n    refundTransactionId: "",\n    refundWebhookKey: ""\n));\n'})}),"\n",(0,t.jsx)(n.h3,{id:"refund-payment",children:"Refund payment"}),"\n",(0,t.jsx)(n.pre,{children:(0,t.jsx)(n.code,{className:"language-csharp",children:'var refundResponse = await sipayPaymentIntegration.RefundAsync(new RefundRequestModel(\n    invoiceId: "",\n    amount: 100,\n    hashKey: "",\n    refundTransactionId: "",\n    refundWebhookKey: ""\n));\n'})})]})}function p(e={}){const{wrapper:n}={...(0,r.a)(),...e.components};return n?(0,t.jsx)(n,{...e,children:(0,t.jsx)(d,{...e})}):d(e)}},1151:(e,n,a)=>{a.d(n,{Z:()=>c,a:()=>i});var t=a(7294);const r={},s=t.createContext(r);function i(e){const n=t.useContext(s);return t.useMemo((function(){return"function"==typeof e?e(n):{...n,...e}}),[n,e])}function c(e){let n;return n=e.disableParentContext?"function"==typeof e.components?e.components(r):e.components||r:i(e.components),t.createElement(s.Provider,{value:n},e.children)}}}]);